using System;
using System.Collections.Generic;
using io.turntabl.RoleService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace io.turntabl.RoleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeContext _context;
        public EmployeesController(EmployeeContext context)
        {
            _context = context;
        }
        
        // GET api/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetRoles()
        {
            return _context.Employees;
        }

        
        // GET api/employees/2
        [HttpGet("{id}")]
        public ActionResult<Employee> GetRole(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }
            
            return employee;
        }

        
        // POST api/employees
        [HttpPost]
        public ActionResult<Employee> PostRole(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return CreatedAtAction("GetRole", new Employee { EmployeeId = employee.EmployeeId }, employee);
        }

        
        // PUT api/employees/2
        [HttpPut("{id}")]
        public ActionResult PutRole(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        
        // DELETE api/employees/2
        [HttpDelete("{id}")]
        public ActionResult<Employee> PutRole(int id)
        {
           var role = _context.Employees.Find(id);
           if(role == null){
               return NotFound();
           }
           _context.Employees.Remove(role);
           _context.SaveChanges();
           
           return role;
        }
        

        [Route("test")]
        [HttpGet]  // for testing
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "working !" };
        }
    }
}