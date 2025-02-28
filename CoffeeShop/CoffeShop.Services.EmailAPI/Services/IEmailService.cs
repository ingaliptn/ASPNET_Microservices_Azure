using CoffeeShop.Services.EmailAPI.Message;
using CoffeeShop.Services.EmailAPI.Models.Dto;

namespace CoffeeShop.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardMessage rewardsDto);

    }
}
