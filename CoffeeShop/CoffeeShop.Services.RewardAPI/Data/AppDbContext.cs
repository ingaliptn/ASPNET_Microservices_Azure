using CoffeeShop.Services.RewardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Services.RewardAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Rewards> Rewards { get; set; }
    }
}
