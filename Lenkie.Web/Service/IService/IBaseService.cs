using Lenkie.Web.Models.DTO;

namespace Lenkie.Web.Service.IService
{
    public interface IBaseService
    {
       Task<ResponseDTO?> SendAsync(RequestDTO requestDTO, bool withBearer = true); 
    }
}
