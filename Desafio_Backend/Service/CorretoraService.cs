using AutoMapper;
using Desafio_Backend.Dto;
using Desafio_Backend.Interfaces;
using Desafio_Backend.Models;

namespace Desafio_Backend.Service
{
    public class CorretoraService : ICorretoraService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public CorretoraService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<CorretoraResponse>> BuscarTodasCorretoras()
        {
            var corretoras = await _brasilApi.BuscarCorretoras();
            return _mapper.Map<ResponseGeneric<CorretoraResponse>>(corretoras);
        }
    }
}
