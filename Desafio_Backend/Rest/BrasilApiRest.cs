using Desafio_Backend.Dto;
using Desafio_Backend.Interfaces;
using Desafio_Backend.Models;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace Desafio_Backend.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGeneric<CorretoraModel>> BuscarCorretora(string cnpjCorretora)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,$"https://brasilapi.com.br/api/cvm/corretoras/v1/{cnpjCorretora}");
            var response = new ResponseGeneric<CorretoraModel>();
            using( var client = new HttpClient())
            {
                var responseBrasilApi=await client.SendAsync(request);
                var contentResp=await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CorretoraModel>(contentResp);
                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErrorRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
               
            }
            return response;
        }

        

        async Task<ResponseGeneric<List<CorretoraModel>>> IBrasilApi.BuscarCorretoras()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cvm/corretoras/v1");
            var response = new ResponseGeneric<List<CorretoraModel>>();

            using (var client = new HttpClient())
            {
                var responseViaCepApi = await client.SendAsync(request);
                var contentResp = await responseViaCepApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<CorretoraModel>>(contentResp);

                if (responseViaCepApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseViaCepApi.StatusCode;
                    response.DadosRetorno = objResponse;

                }
                else
                {
                    response.CodigoHttp = responseViaCepApi.StatusCode;
                    response.ErrorRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }
            return response;
        }
    }
}
