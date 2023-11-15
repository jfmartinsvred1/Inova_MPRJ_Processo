using AutoMapper;
using Desafio_Backend.Dto;
using Desafio_Backend.Models;

namespace Desafio_Backend.Profiles
{
    public class CepMapping:Profile
    {
        public CepMapping() 
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<CepResponse, CepModel>();
            CreateMap<CepModel, CepResponse>();
        }
    }
}
