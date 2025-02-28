using CoffeeShop.Services.ShoppingCartAPI.Models.Dto;

namespace CoffeeShop.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
