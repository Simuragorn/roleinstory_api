using EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using RoleInStory.Core.Entities.Identity;

namespace RoleInStory.Infrastructure.Seed
{
    public class RoleInStoryDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Zerg",
                    Email = "zerg@test.com",
                    UserName = "zerg@test.com",
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
