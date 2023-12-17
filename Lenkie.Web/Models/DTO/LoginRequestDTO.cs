using System.ComponentModel.DataAnnotations;

namespace Lenkie.Web.Models.DTO
{
    public class LoginRequestDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
