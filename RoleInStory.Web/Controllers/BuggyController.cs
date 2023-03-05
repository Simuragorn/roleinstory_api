using EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet("testauth")]
        public ActionResult<string> GetSecretText()
        {
            return "secret stuff";
        }


        [HttpGet("notfounderror")]
        public ActionResult GetNotFoundError()
        {
            return NotFound(new ApiResponse(404));
        }

        [HttpGet("servererror")]
        public ActionResult GetServerError()
        {
            Location location = null;
            location.Name = "";

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
