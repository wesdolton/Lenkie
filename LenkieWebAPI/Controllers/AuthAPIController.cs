using LenkieWebAPI.Data;
using LenkieWebAPI.Models;
using LenkieWebAPI.Models.DTO;
using LenkieWebAPI.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace LenkieWebAPI.Controllers
{
    [Route("api/authAPI")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly AppDbContext _db;
        protected ResponseDTO _response;

        public AuthAPIController(IAuthService authService, AppDbContext db)
        {
            _authService = authService;
            _db = db;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDTO model)
        {

            var errorMessage = await _authService.Register(model);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccessful = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }

            if (!model.Role.IsNullOrEmpty() && model.Role != "ADMIN")
            {
                Customer customer = new Customer
                                    {
                                        Name = model.Name,
                                        Email = model.Email,
                                    };
                _db.Customers.Add(customer);
                _db.SaveChanges();
            }

            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
        {
            var loginResponse = await _authService.Login(model);

            if (loginResponse.User == null)
            {
                _response.IsSuccessful = false;
                _response.Message = "Username or password incorrect";
                return BadRequest(_response);
            }

            _response.Result = loginResponse;

            return Ok(_response);
        }

        [HttpPost("AssignRole")]
        public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDTO model)
        {
            var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());

            if (!assignRoleSuccessful)
            {
                _response.IsSuccessful = false;
                _response.Message = "Error Encountered";
                return BadRequest(_response);
            }
            return Ok(_response);
        }
    }
}
