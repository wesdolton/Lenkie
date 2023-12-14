using Microsoft.AspNetCore.Identity;

namespace LenkieWebAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
