using System;
using System.Collections.Generic;
using System.IO;

namespace AGRIOT
{
    /// <summary>
    /// Configuración leída del archivo .env (copiado junto al .exe) o, si falta, de variables de entorno.
    /// El .env real está en .gitignore; en el repo solo va .env.example.
    /// </summary>
    internal static class AppConfig
    {
        private static readonly Dictionary<string, string> Valores = CargarEnv();

        public static string MqttBroker => Obtener("MQTT_BROKER");
        public static int MqttPort => int.TryParse(Obtener("MQTT_PORT"), out int p) ? p : 8883;
        public static string MqttUsuario => Obtener("MQTT_USER");
        public static string MqttPassword => Obtener("MQTT_PASSWORD");
        public static string MqttTopic => Obtener("MQTT_TOPIC", "agro/estacion/sensores");

        private static string Obtener(string clave, string porDefecto = "")
        {
            if (Valores.TryGetValue(clave, out string v) && v.Length > 0) return v;
            string env = Environment.GetEnvironmentVariable(clave);
            return string.IsNullOrEmpty(env) ? porDefecto : env;
        }

        private static Dictionary<string, string> CargarEnv()
        {
            var d = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            if (!File.Exists(ruta)) return d;

            foreach (string linea in File.ReadAllLines(ruta))
            {
                string t = linea.Trim();
                if (t.Length == 0 || t.StartsWith("#")) continue;
                int i = t.IndexOf('=');
                if (i <= 0) continue;
                d[t.Substring(0, i).Trim()] = t.Substring(i + 1).Trim().Trim('"');
            }
            return d;
        }
    }
}
