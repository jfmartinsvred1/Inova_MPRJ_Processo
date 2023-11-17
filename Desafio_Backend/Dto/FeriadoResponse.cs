using System.Text.Json.Serialization;

namespace Desafio_Backend.Dto
{
    public class FeriadoResponse
    {
        public string Data { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}
