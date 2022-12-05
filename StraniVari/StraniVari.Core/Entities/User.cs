using Microsoft.AspNetCore.Identity;

namespace StraniVari.Core.Entities
{
    public class User:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string UserRole { get; set; }
    }
}
