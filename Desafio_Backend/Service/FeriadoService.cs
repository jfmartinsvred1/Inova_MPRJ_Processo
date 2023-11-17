using AutoMapper;
using Desafio_Backend.Dto;
using Desafio_Backend.Interfaces;

namespace Desafio_Backend.Service
{
    public class FeriadoService : IFeriadoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public FeriadoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<List<FeriadoResponse>>> BuscarTodosFeriados(string ano)
        {
            var feriados = await _brasilApi.BuscarFeriados(ano);
            return _mapper.Map<ResponseGeneric<List<FeriadoResponse>>>(feriados);
        }
    }
}
