using RoleInStory.Application.Services.Locations.Dtos;
using RoleInStory.Business.Services.BaseService;
using RoleInStory.Core.Entities;

namespace RoleInStory.Application.Services.Locations
{
    public interface ILocationService : IGeneralService<Location, LocationDto>
    {
    }
}
