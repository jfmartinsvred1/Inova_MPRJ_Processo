using System.Text.Json.Serialization;

namespace Desafio_Backend.Models
{
    public class CepModel
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        [JsonPropertyName("complemento")]
        public string? Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string? localidade { get; set; }

        [JsonPropertyName("uf")]
        public string? uf { get; set; }

        [JsonPropertyName("ibge")]
        public string? ibge { get; set; }

        [JsonPropertyName("gia")]
        public string? gia { get; set; }

        [JsonPropertyName("ddd")]
        public string? ddd { get; set; }

        [JsonPropertyName("siafi")]
        public string? siafi { get; set; }
    }
}
