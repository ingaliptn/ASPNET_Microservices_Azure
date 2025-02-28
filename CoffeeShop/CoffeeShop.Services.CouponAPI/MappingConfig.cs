using AutoMapper;
using CoffeeShop.Services.CouponAPI.Models;
using CoffeeShop.Services.CouponAPI.Models.Dto;

namespace CoffeeShop.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
