using CoffeeShop.Services.AuthAPI.Models;

namespace CoffeeShop.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
