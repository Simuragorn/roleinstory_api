using RoleInStory.Application.Dtos;
using System.ComponentModel.DataAnnotations;

namespace RoleInStory.Application.Services.Locations.Dtos
{
    public class LocationDto : BaseEntityDto
    {
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
