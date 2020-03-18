using System;
using System.Collections.Generic;
using io.turntabl.RoleService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace io.turntabl.RoleService.Controllers
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

        [HttpGet]
        public ActionResult<IEnumerable<Role>> GetRoles()
        {
            return _context.Roles;
        }

        [HttpGet("{id}")]
        public ActionResult<Role> GetRole(int id)
        {
            var role = _context.Roles.Find(id);

            if (role == null)
            {
                return NotFound();
            }

            return role;
        }

        [HttpPost]
        public ActionResult<Role> PostRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();

            return CreatedAtAction("GetRole", new Role { Id = role.Id }, role);
        }

        [HttpPut("{id}")]
        public ActionResult PutRole(int id, Role role)
        {
            if (id != role.Id)
            {
                return BadRequest();
            }

            _context.Entry(role).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Role> PutRole(int id)
        {
           var role = _context.Roles.Find(id);
           if(role == null){
               return NotFound();
           }
           _context.Roles.Remove(role);
           _context.SaveChanges();
           
           return role;
        }

        // [HttpGet]  
        // public ActionResult<IEnumerable<string>> GetString()
        // {
        //     return new string[] { "this", "is", "working !" };
        // }
    }
}