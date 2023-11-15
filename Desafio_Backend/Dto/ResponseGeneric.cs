using System.Dynamic;
using System.Net;

namespace Desafio_Backend.Dto
{
    public class ResponseGeneric<T> where T : class
    {
        public HttpStatusCode CodigoHttp {  get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErrorRetorno { get; set; }


    }
}
