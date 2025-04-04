﻿using Microsoft.AspNetCore.Mvc;
using RoleInStory.Web.Errors;

namespace RoleInStory.Web.Controllers
{
    [Route("errors")]
    public class ErrorController : BaseApiController
    {
        [HttpGet("{code}")]
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
