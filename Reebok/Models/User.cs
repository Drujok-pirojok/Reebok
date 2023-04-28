using Microsoft.AspNetCore.Identity;

namespace Reebok.Web.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}