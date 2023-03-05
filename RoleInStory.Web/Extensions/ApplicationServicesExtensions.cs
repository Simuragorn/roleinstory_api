using RoleInStory.Application.Services.Locations;
using RoleInStory.Business.Services.Auth;

namespace RoleInStory.Web.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ILocationService, LocationService>();
            return services;
        }
    }
}
