
using Lenkie.Web.Models.DTO;
using Lenkie.Web.Models.Utility;
using Lenkie.Web.Service.IService;

namespace Lenkie.Web.Service
{
    public class AuthService : IAuthService
    {
        private readonly IBaseService _baseService;

        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;  
        }
        public async Task<ResponseDTO> AssignRoleAsync(RegistrationRequestDTO registrationRequestDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.LenkieWebAPIBase + "/api/authAPI/AssignRole",
                Data = registrationRequestDTO
            });
        }

        public async Task<ResponseDTO> LoginAsync(LoginRequestDTO loginRequestDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.LenkieWebAPIBase + "/api/authAPI/login",
                Data = loginRequestDTO
            }, withBearer: false);
        }

        public async Task<ResponseDTO> RegisterAsync(RegistrationRequestDTO registrationRequestDTO)
        {
            return await _baseService.SendAsync(new RequestDTO()
            {
                ApiType = SD.ApiType.POST,
                Url = SD.LenkieWebAPIBase + "/api/authAPI/register",
                Data = registrationRequestDTO
            }, withBearer: false);
        }
    }
}
