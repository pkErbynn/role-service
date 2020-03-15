using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace role_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "working !" };
        }
    }
}