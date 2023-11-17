using Desafio_Backend.Dto;

namespace Desafio_Backend.Interfaces
{
    public interface IFeriadoService
    {
        Task<ResponseGeneric<List<FeriadoResponse>>> BuscarTodosFeriados(string ano);
    }
}
