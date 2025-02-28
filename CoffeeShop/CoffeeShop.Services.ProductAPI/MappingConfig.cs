using AutoMapper;
using CoffeeShop.Services.ProductAPI.Models;
using CoffeeShop.Services.ProductAPI.Models.Dto;

namespace CoffeeShop.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();//.ReverseMap();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
