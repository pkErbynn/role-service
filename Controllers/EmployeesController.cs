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
            return _context.employees;
        }

        
        // GET api/employees/2
        [HttpGet("{id}")]
        public ActionResult<Employee> GetRole(int id)
        {
            var employee = _context.employees.Find(id);

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
            _context.employees.Add(employee);
            _context.SaveChanges();

            return CreatedAtAction("GetRole", new Employee { employeeid = employee.employeeid }, employee);
        }

        
        // PUT api/employees/2
        [HttpPut("{id}")]
        public ActionResult PutRole(int id, Employee employee)
        {
            if (id != employee.employeeid)
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
           var role = _context.employees.Find(id);
           if(role == null){
               return NotFound();
           }
           _context.employees.Remove(role);
           _context.SaveChanges();
           
           return role;
        }
        

        // api/test .... for testing
        [Route("test")]
        [HttpGet]  
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "working !" };
        }
    }
}