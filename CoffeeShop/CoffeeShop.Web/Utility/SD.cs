namespace CoffeeShop.Web.Utility
{
    public class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string ProductAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public static string ShoppingCartAPIBase { get; set; }
        public static string OrderAPIBase { get; set; }

        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";

        public const string TokenCookie = "JWTToken";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public const string Status_Pending = "Pending";
        public const string Status_Approved = "Approved";
        public const string Status_ReadyForPickup = "ReadyForPickup";
        public const string Status_Compteted = "Completed";
        public const string Status_Refunded = "Refunded";
        public const string Status_Cancelled = "Cancelled";
        //public const string Status_Pending = "В очікуванні";
        //public const string Status_Approved = "Підтвердженно";
        //public const string Status_ReadyForPickup = "Готовий до отримання";
        //public const string Status_Compteted = "Виконано";
        //public const string Status_Refunded = "Повернено";
        //public const string Status_Cancelled = "Скасовано";


        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
    }
}
