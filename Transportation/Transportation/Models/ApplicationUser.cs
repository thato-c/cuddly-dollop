using Microsoft.AspNetCore.Identity;

namespace Transportation.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int HouseNumber { get; set; }

        public string StreetName { get; set; } = string.Empty;

        public string Town { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;
    }
}
