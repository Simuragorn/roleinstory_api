using Microsoft.AspNetCore.Identity;

namespace RoleInStory.Core.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
