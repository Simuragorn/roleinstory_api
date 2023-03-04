using Microsoft.AspNetCore.Identity;

namespace RoleInStory.Core.Entities
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
