using Desafio_Backend.Dto;
using Desafio_Backend.Interfaces;
using Desafio_Backend.Models;
using System.Dynamic;
using System.Text.Json;

namespace Desafio_Backend.Rest
{
    public class ViaCepRest : IViaCepApi
    {
        public async Task<ResponseGeneric<CepModel>> BuscarCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://viacep.com.br/ws/{cep}/json/");
            var response =  new ResponseGeneric<CepModel>();

            using ( var client = new HttpClient() )
            {
                var responseViaCepApi = await client.SendAsync( request );
                var contentResp = await responseViaCepApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<CepModel>( contentResp );

                if (responseViaCepApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseViaCepApi.StatusCode;
                    response.DadosRetorno = objResponse;

                }
                else
                {
                    response.CodigoHttp = responseViaCepApi.StatusCode;
                    response.ErrorRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp );
                }
               
            }
            return response;
        }
    }
}
