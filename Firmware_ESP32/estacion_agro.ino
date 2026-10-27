/*
  AGRIOT - Estación agrometeorológica (ESP32)

  Sensores:
    - DHT22   -> pin D2 (GPIO2)   temperatura y humedad
    - UVM-30A -> pin A0           salida analógica 0-1 V (índice UV 0-11+)

  Publica cada 2 s un JSON en MQTT (EMQX) con retained=true en el topic agro/estacion/sensores:
    {"temperatura":24.5,"humedad":61.2,"voltaje_mv":318,"indice_uv":2.0,"categoria_uv":"Bajo"}

  Librerías (Administrador de bibliotecas de Arduino IDE):
    - WiFiManager         (tzapu)
    - PubSubClient        (Nick O'Leary)
    - DHT sensor library  (Adafruit) + Adafruit Unified Sensor

  Primera conexión / cambio de red:
    el ESP32 abre el hotspot "AGRIOT-Estacion" (contraseña definida abajo);
    conéctate desde el celular y elige la red WiFi en el portal que aparece.
    Para borrar las credenciales guardadas, mantén presionado el botón BOOT
    (GPIO0) mientras se reinicia la placa.
*/

#include <WiFi.h>
#include <WiFiClientSecure.h>
#include <WiFiManager.h>
#include <PubSubClient.h>
#include <DHT.h>
#include "secrets.h"   // credenciales (no se sube a git)

// ---------- Configuración ----------
const char* MQTT_BROKER = SECRET_MQTT_BROKER;   // EMQX Cloud
const uint16_t MQTT_PORT = SECRET_MQTT_PORT;   // MQTT sobre TLS
const char* MQTT_TOPIC = "agro/estacion/sensores";
const char* MQTT_TOPIC_N8N = "agro/estacion/resumen";   // lo escucha n8n (baja frecuencia)
const unsigned long N8N_INTERVAL_MS = 600000;            // 10 min: cada mensaje dispara una ejecución en n8n
const char* MQTT_USER = SECRET_MQTT_USER;   // vacío si el broker no exige autenticación
const char* MQTT_PASS = SECRET_MQTT_PASS;

const char* AP_NAME = "AGRIOT-Estacion";
const char* AP_PASS = SECRET_AP_PASS;       // mínimo 8 caracteres

const unsigned long PUBLISH_INTERVAL_MS = 2000;
const unsigned long MQTT_RETRY_MS = 5000;

#define PIN_DHT 2                             // D2
#define DHT_TYPE DHT22
#define PIN_UV A0                             // GPIO36 (ADC1) en ESP32 DevKit; ADC1 funciona con WiFi activo
#define PIN_RESET_WIFI 0                      // botón BOOT

// ---------- Objetos ----------
DHT dht(PIN_DHT, DHT_TYPE);
WiFiClientSecure wifiClient;
PubSubClient mqtt(wifiClient);

float ultimaTemperatura = NAN;
float ultimaHumedad = NAN;
unsigned long ultimoPublish = 0;
unsigned long ultimoIntentoMqtt = 0;
unsigned long ultimoN8n = 0;

// Curva del UVM-30A (hoja de datos): mV de salida para índice UV 0..11
const int UV_MV[12] = {50, 227, 318, 408, 503, 606, 696, 795, 881, 976, 1079, 1170};

// ---------- Utilidades UV ----------
int leerVoltajeUvMv() {
  // Promedio de 16 muestras para suavizar el ruido del ADC
  uint32_t suma = 0;
  for (int i = 0; i < 16; i++) {
    suma += analogReadMilliVolts(PIN_UV);
    delay(2);
  }
  return suma / 16;
}

float calcularIndiceUv(int mv) {
  if (mv <= UV_MV[0]) return 0.0f;
  if (mv >= UV_MV[11]) return 11.0f;
  for (int i = 0; i < 11; i++) {
    if (mv < UV_MV[i + 1]) {
      float fraccion = (float)(mv - UV_MV[i]) / (UV_MV[i + 1] - UV_MV[i]);
      return i + fraccion;
    }
  }
  return 11.0f;
}

const char* categoriaUv(float indice) {
  if (indice < 3.0f) return "Bajo";
  if (indice < 6.0f) return "Moderado";
  if (indice < 8.0f) return "Alto";
  if (indice < 11.0f) return "Muy alto";
  return "Extremo";
}

// ---------- MQTT ----------
void conectarMqtt() {
  if (mqtt.connected()) return;
  if (millis() - ultimoIntentoMqtt < MQTT_RETRY_MS && ultimoIntentoMqtt != 0) return;
  ultimoIntentoMqtt = millis();

  String clientId = "agriot-esp32-" + String((uint32_t)ESP.getEfuseMac(), HEX);
  Serial.print("Conectando a MQTT... ");
  bool ok = (strlen(MQTT_USER) > 0)
              ? mqtt.connect(clientId.c_str(), MQTT_USER, MQTT_PASS)
              : mqtt.connect(clientId.c_str());
  if (ok) {
    Serial.println("OK");
  } else {
    Serial.printf("fallo (rc=%d)\n", mqtt.state());
  }
}

void publicarLectura() {
  float t = dht.readTemperature();
  float h = dht.readHumidity();
  // El DHT22 solo refresca cada ~2 s: si una lectura falla se conserva la última válida
  if (!isnan(t)) ultimaTemperatura = t;
  if (!isnan(h)) ultimaHumedad = h;

  int mv = leerVoltajeUvMv();
  float uv = calcularIndiceUv(mv);

  char tempStr[12] = "null";
  char humStr[12] = "null";
  if (!isnan(ultimaTemperatura)) snprintf(tempStr, sizeof(tempStr), "%.1f", ultimaTemperatura);
  if (!isnan(ultimaHumedad)) snprintf(humStr, sizeof(humStr), "%.1f", ultimaHumedad);

  char payload[160];
  snprintf(payload, sizeof(payload),
           "{\"temperatura\":%s,\"humedad\":%s,\"voltaje_mv\":%d,\"indice_uv\":%.1f,\"categoria_uv\":\"%s\"}",
           tempStr, humStr, mv, uv, categoriaUv(uv));

  // retained = true: el broker guarda el último mensaje y lo entrega a quien se suscriba después
  bool ok = mqtt.publish(MQTT_TOPIC, payload, true);
  Serial.printf("%s %s\n", ok ? "TX" : "TX-ERR", payload);

  if (ultimoN8n == 0 || millis() - ultimoN8n >= N8N_INTERVAL_MS) {
    ultimoN8n = millis();
    mqtt.publish(MQTT_TOPIC_N8N, payload, true);
  }
}

// ---------- Arduino ----------
void setup() {
  Serial.begin(115200);
  delay(200);

  pinMode(PIN_RESET_WIFI, INPUT_PULLUP);
  analogSetPinAttenuation(PIN_UV, ADC_11db);
  dht.begin();

  WiFiManager wm;
  if (digitalRead(PIN_RESET_WIFI) == LOW) {
    Serial.println("BOOT presionado: borrando credenciales WiFi");
    wm.resetSettings();
  }
  wm.setConfigPortalTimeout(180);   // si nadie configura en 3 min, reinicia y reintenta
  if (!wm.autoConnect(AP_NAME, AP_PASS)) {
    Serial.println("Sin WiFi, reiniciando...");
    ESP.restart();
  }
  Serial.print("WiFi OK, IP: ");
  Serial.println(WiFi.localIP());

  // TLS sin validar el certificado del servidor (simple para pruebas).
  // Para validarlo, usa wifiClient.setCACert(<CA raíz DigiCert Global Root>) en lugar de setInsecure().
  wifiClient.setInsecure();
  mqtt.setServer(MQTT_BROKER, MQTT_PORT);
}

void loop() {
  if (WiFi.status() != WL_CONNECTED) {
    WiFi.reconnect();
    delay(500);
    return;
  }

  conectarMqtt();
  mqtt.loop();

  if (mqtt.connected() && millis() - ultimoPublish >= PUBLISH_INTERVAL_MS) {
    ultimoPublish = millis();
    publicarLectura();
  }
}
