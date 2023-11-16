using Desafio_Backend.Dto;
using Desafio_Backend.Interfaces;
using Desafio_Backend.Models;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace Desafio_Backend.Rest
{
    public class BrasilRest : IBrasilApi
    {
        public async Task<ResponseGeneric<CorretoraModel>> BuscarCorretoras()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cvm/corretoras/v1");
            var response = new ResponseGeneric<CorretoraModel>();

            using (var client = new HttpClient())
            {
                var responseViaCepApi = await client.SendAsync(request);
                var contentResp = await responseViaCepApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CorretoraModel>(contentResp);

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
