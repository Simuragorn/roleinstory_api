using EntityFrameworkCore;

namespace RoleInStory.Infrastructure.Seed
{
    public class DBInitializer
    {
        public static void Initialize(RoleInStoryContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
