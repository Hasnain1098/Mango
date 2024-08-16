namespace Mango.Services.CouponAPI.Models.DTOs
{
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool? IsSuccess { get; set; } = true;
        public String Message { get; set; } = "";

    }
}
