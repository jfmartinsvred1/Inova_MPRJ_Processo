using AutoMapper;
using Desafio_Backend.Dto;
using Desafio_Backend.Models;

namespace Desafio_Backend.Profiles
{
    public class FeriadoMapping:Profile
    {
        public FeriadoMapping()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<FeriadoResponse, FeriadoModel>();
            CreateMap<FeriadoModel, FeriadoResponse>();
        }
    }
}
