using Desafio_Backend.Dto;

namespace Desafio_Backend.Interfaces
{
    public interface ICepService
    {
        Task<ResponseGeneric<CepResponse>> BuscarEnderecoPorCep(string cep);
    }
}
