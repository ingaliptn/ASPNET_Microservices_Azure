using CoffeeShop.Services.RewardAPI.Message;

namespace CoffeeShop.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardMessage rewardMessage);

    }
}
