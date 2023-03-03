using RoleInStory.Application.Dtos;

namespace RoleInStory.Application.Services.Locations.Dtos
{
    public class LocationDto : BaseEntityDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
