﻿using LenkieWebAPI.Models.DTO;
using LenkieWebAPI.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LenkieWebAPI.Controllers
{
    [Route("api/authAPI")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthService _authService;
        protected ResponseDTO _response;

        public AuthAPIController(IAuthService authService)
        {
            _authService = authService;
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
