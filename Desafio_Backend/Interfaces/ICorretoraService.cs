using Desafio_Backend.Dto;
using Desafio_Backend.Models;

namespace Desafio_Backend.Interfaces
{
    public interface ICorretoraService
    {
        Task<ResponseGeneric<List<CorretoraResponse>>> BuscarTodasCorretoras();
        Task<ResponseGeneric<CorretoraResponse>> BuscarCorretora(string cnpj);
    }
}
