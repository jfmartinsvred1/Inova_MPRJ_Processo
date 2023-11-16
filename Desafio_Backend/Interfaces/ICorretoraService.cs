using Desafio_Backend.Dto;

namespace Desafio_Backend.Interfaces
{
    public interface ICorretoraService
    {
        Task<ResponseGeneric<CorretoraResponse>> BuscarTodasCorretoras();
    }
}
