using static CoffeeShop.Web.Utility.SD;

namespace CoffeeShop.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET; //Define Get, Post, Put, Delete req
        public string Url { get; set; } 
        public object Data { get; set; }
        public string AccessToken { get; set; }
        public ContentType ContentType { get; set; } = ContentType.Json;
    }
}
