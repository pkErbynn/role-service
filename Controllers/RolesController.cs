using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using role_api.Models;

namespace role_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleContext _context;
        public RolesController(RoleContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<Role>> GetRoles()
        // {
        //     return _context.Roles;
        // }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "working !" };
        }
    }
}