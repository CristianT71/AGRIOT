using System;
using Newtonsoft.Json;

namespace AGRIOT
{
    /// <summary>Lectura publicada por el ESP32 en agro/estacion/sensores.</summary>
    public class LecturaSensores
    {
        [JsonProperty("temperatura")]
        public double? Temperatura { get; set; }

        [JsonProperty("humedad")]
        public double? Humedad { get; set; }

        [JsonProperty("voltaje_mv")]
        public double VoltajeMv { get; set; }

        [JsonProperty("indice_uv")]
        public double IndiceUv { get; set; }

        [JsonProperty("categoria_uv")]
        public string CategoriaUv { get; set; }

        /// <summary>Momento de recepción en el cliente (el firmware no envía hora).</summary>
        [JsonIgnore]
        public DateTime Recibida { get; set; } = DateTime.Now;

        /// <summary>True si el broker entregó el mensaje retenido (último valor guardado) al suscribirse.</summary>
        [JsonIgnore]
        public bool Retenida { get; set; }
    }
}
