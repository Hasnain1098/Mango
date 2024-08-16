namespace Mango.Web.Utility
{
    public class StaticDetails
    {
        public static string CouponApiBase { set; get; }
        public enum ApiType
        {
            GET,
            POST, 
            PUT,
            DELETE,
        }
    }
}
