using CoffeeShop.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Coupon>().HasData(new Coupon
            //{
            //    CouponId = 1,
            //    CouponCode = "15OFF",
            //    DiscountAmount = 15,
            //    MinAmount = 30
            //});

            //modelBuilder.Entity<Coupon>().HasData(new Coupon
            //{
            //    CouponId = 2,
            //    CouponCode = "20OFF",
            //    DiscountAmount = 20,
            //    MinAmount = 40
            //});
        }
    }
}
