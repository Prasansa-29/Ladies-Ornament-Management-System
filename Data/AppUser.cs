using Microsoft.AspNetCore.Identity;

namespace FANCY_CLOTHES_MANAGEMENT.Data
{
    public class AppUser : IdentityUser

    {

        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Role { get; set; }


    }
}

