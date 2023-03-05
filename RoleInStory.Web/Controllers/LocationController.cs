using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoleInStory.Application.Services.Locations;
using RoleInStory.Application.Services.Locations.Dtos;

namespace RoleInStory.Web.Controllers
{
    [Authorize]
    public class LocationController : BaseApiController
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }


        [HttpGet]
        public async Task<ActionResult<List<LocationDto>>> GetAll()
        {
            return await _locationService.GetAllAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationDto>> Get(int id)
        {
            return await _locationService.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<LocationDto>> Post([FromBody] LocationDto location)
        {
            return await _locationService.CreateAsync(location);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LocationDto>> Put(int id, [FromBody] LocationDto location)
        {
            location.Id = id;
            return await _locationService.UpdateAsync(location);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationDto>> Delete(int id)
        {
            return await _locationService.DeleteAsync(id);
        }

    }
}
