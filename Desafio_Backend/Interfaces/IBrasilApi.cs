using Desafio_Backend.Dto;
using Desafio_Backend.Models;

namespace Desafio_Backend.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGeneric<List<CorretoraModel>>> BuscarCorretoras();
        Task<ResponseGeneric<CorretoraModel>> BuscarCorretora(string cnpjCorretora);
    }
}
