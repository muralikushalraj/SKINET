using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using CORE.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(x=>x.ProductBrand, y=>y.MapFrom(z=>z.ProductBrand.Name))
            .ForMember(x=>x.ProductType, y=>y.MapFrom(z=>z.ProductType.Name))
            .ForMember(x=>x.PictureURL, y=>y.MapFrom<ProductUrlResolver>());
        }
    }
}