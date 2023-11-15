using AutoMapper;
using Desafio_Backend.Dto;
using Desafio_Backend.Interfaces;

namespace Desafio_Backend.Service
{
    public class CepService : ICepService
    {
        private readonly IMapper _mapper;
        private readonly IViaCepApi _viaCepApi;

        public CepService(IMapper mapper, IViaCepApi viaCepApi)
        {
            _mapper = mapper;
            _viaCepApi = viaCepApi;
        }

        public async Task<ResponseGeneric<CepResponse>> BuscarEnderecoPorCep(string cep)
        {
            var endereco = await _viaCepApi.BuscarCep(cep);
            return _mapper.Map<ResponseGeneric<CepResponse>>(endereco);
        }
    }
}
