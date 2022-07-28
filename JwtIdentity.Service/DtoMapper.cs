using AutoMapper;
using JwtIdentity.Core.Dtos;
using JwtIdentity.Core.Entities;

namespace JwtIdentity.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();

        }
    }
}