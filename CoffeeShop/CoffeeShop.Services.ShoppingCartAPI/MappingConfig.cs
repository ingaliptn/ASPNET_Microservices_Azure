using AutoMapper;
using CoffeeShop.Services.ShoppingCartAPI.Models;
using CoffeeShop.Services.ShoppingCartAPI.Models.Dto;

namespace CoffeeShop.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
