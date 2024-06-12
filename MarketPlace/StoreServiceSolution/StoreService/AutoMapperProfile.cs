using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MarketService;

namespace StoreService
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}