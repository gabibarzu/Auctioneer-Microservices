using Microsoft.AspNetCore.Identity;

namespace AuthenticationApi.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}