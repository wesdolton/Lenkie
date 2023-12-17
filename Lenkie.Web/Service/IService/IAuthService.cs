using Lenkie.Web.Models.DTO;

namespace Lenkie.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDTO> LoginAsync(LoginRequestDTO loginRequestDTO);
        Task<ResponseDTO> RegisterAsync(RegistrationRequestDTO registrationRequestDTO);
        Task<ResponseDTO>  AssignRoleAsync(RegistrationRequestDTO registrationRequestDTO);
    }
}
