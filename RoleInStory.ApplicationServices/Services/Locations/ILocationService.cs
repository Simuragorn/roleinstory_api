using RoleInStory.Application.Services.Locations.Dtos;

namespace RoleInStory.Application.Services.Locations
{
    public interface ILocationService
    {
        Task<IReadOnlyList<LocationDto>> GetAllAsync();

        Task<LocationDto> CreateAsync(LocationDto locationDto);
        Task<LocationDto> UpdateAsync(LocationDto locationDto);
    }
}
