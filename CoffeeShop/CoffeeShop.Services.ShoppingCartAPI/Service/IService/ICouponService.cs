using CoffeeShop.Services.ShoppingCartAPI.Models.Dto;

namespace CoffeeShop.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
