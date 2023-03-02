using Microsoft.AspNetCore.Mvc;
using RoleInStory.Application.Services.Locations;
using RoleInStory.Application.Services.Locations.Dtos;
using RoleInStory.Core.Entities;

namespace RoleInStory.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<LocationDto>>> GetAll()
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
