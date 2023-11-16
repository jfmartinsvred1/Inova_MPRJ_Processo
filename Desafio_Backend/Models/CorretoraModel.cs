using System.Text.Json.Serialization;

namespace Desafio_Backend.Models
{
    public class CorretoraModel
    {
        [JsonPropertyName("bairro")]
        public string bairro { get; set; }

        [JsonPropertyName("cep")]
        public string cep { get; set; }

        [JsonPropertyName("cnpj")]
        public string cnpj { get; set; }

        [JsonPropertyName("codigo_cvm")]
        public string codigo_cvm { get; set; }

        [JsonPropertyName("complemento")]
        public string complemento { get; set; }

        [JsonPropertyName("data_inicio_situacao")]
        public string data_inicio_situacao { get; set; }

        [JsonPropertyName("data_patrimonio_liquido")]
        public string data_patrimonio_liquido { get; set; }

        [JsonPropertyName("data_registro")]
        public string data_registro { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("logradouro")]
        public string logradouro { get; set; }

        [JsonPropertyName("municipio")]
        public string municipio { get; set; }

        [JsonPropertyName("nome_social")]
        public string nome_social { get; set; }

        [JsonPropertyName("nome_comercial")]
        public string nome_comercial { get; set; }

        [JsonPropertyName("pais")]
        public string pais { get; set; }

        [JsonPropertyName("status")]
        public string status { get; set; }

        [JsonPropertyName("telefone")]
        public string telefone { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("uf")]
        public string uf { get; set; }

        [JsonPropertyName("valor_patrimonio_liquido")]
        public string valor_patrimonio_liquido { get; set; }
    }
}
