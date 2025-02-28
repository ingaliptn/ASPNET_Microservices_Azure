using CoffeeShop.Web.Models;

namespace CoffeeShop.Web.Service.IService
{
    public interface IBaseService
    {
       Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true); //Task make it async
    }
}
