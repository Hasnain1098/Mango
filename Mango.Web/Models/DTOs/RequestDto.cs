using static Mango.Web.Utility.StaticDetails;

namespace Mango.Web.Models.DTOs;

public class RequestDto
{
    public ApiType ApiType { get; set; } = ApiType.GET;
    public string Url{ get; set; }
    public object Data{ get; set; }
    public string AccesToken{ get; set; }
}

