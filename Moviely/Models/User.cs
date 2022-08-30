using Microsoft.AspNetCore.Identity;

namespace Moviely.Models
{
    public class User : IdentityUser
    {
        public string Username { get; set; }
        public string password { get; set; }
    }
}
