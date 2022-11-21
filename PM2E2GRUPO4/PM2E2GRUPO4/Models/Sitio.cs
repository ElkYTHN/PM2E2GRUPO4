using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM2E2GRUPO4.Models
{
    public class Sitio
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("latitud")]
        public double Latitude { get; set; }

        [JsonProperty("longitud")]
        public double Longitude { get; set; }

        [JsonProperty("descripcion")]
        public String Description { get; set; }

        [JsonProperty("fotografia")]
        public byte[] Image { get; set; }

        [JsonProperty("audiofile")]
        public byte[] AudioFile { get; set; }
        
    }
}

