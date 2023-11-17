using System.Text.Json.Serialization;

namespace Desafio_Backend.Models
{
    public class FeriadoModel
    {
        [JsonPropertyName("date")]
        public string Data { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("type")]
        public string Tipo { get; set; }
    }
}
