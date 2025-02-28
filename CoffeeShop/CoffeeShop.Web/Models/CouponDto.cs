namespace CoffeeShop.Web.Models
{
    public class CouponDto
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; } //% of discount
        public int MinAmount { get; set; } //min value for coupon applied

    }
}
