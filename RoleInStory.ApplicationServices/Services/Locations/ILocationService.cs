using RoleInStory.Application.Services.Locations.Dtos;

namespace RoleInStory.Application.Services.Locations
{
    public interface ILocationService
    {
        Task<List<LocationDto>> GetAllAsync();
    }
}
