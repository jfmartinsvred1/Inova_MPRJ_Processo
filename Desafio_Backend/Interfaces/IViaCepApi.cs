using Desafio_Backend.Dto;
using Desafio_Backend.Models;

namespace Desafio_Backend.Interfaces
{
    public interface IViaCepApi
    {
        Task<ResponseGeneric<CepModel>> BuscarCep(string cep);
    }
}
