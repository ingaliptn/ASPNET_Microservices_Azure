
using CoffeeShop.Services.OrderAPI.Models.Dto;

namespace CoffeeShop.Services.OrderAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
