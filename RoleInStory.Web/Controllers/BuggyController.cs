using EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RoleInStory.Core.Entities;
using RoleInStory.Web.Errors;

namespace RoleInStory.Web.Controllers
{
    public class BuggyController : BaseAPIController
    {
        private readonly RoleInStoryContext _dbContext;
        public BuggyController(RoleInStoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("notfounderror")]
        public ActionResult GetNotFoundError()
        {
            return NotFound(new APIResponse(404));
        }

        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            Location location = null;
            location.ImageUrl = "";

            return Ok();
        }

        [HttpGet("badrequesterror")]
        public ActionResult GetBadRequestError()
        {
            return BadRequest();
        }

        [HttpGet("badrequesterror/{id}")]
        public ActionResult GetBadRequestError(int id)
        {
            return BadRequest();
        }
    }
}
