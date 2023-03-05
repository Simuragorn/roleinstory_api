using Microsoft.AspNetCore.Mvc;
using RoleInStory.Application.Services.Locations;
using RoleInStory.Application.Services.Locations.Dtos;

namespace RoleInStory.Web.Controllers
{
    public class LocationController : BaseAPIController
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<LocationDto>>> GetAll()
        {
            var locations = await _locationService.GetAllAsync();
            return new OkObjectResult(locations);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
