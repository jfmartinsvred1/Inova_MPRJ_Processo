using AutoMapper;
using Desafio_Backend.Dto;
using Desafio_Backend.Models;

namespace Desafio_Backend.Profiles
{
    public class CorretoraMapping:Profile
    {
        public CorretoraMapping()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<CorretoraResponse, CorretoraModel>();
            CreateMap<CorretoraModel, CorretoraResponse>();
        }
    }
}
