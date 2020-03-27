using System;
using System.Collections.Generic;
using System.Linq;
using io.turntabl.RoleService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace io.turntabl.RoleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly RoleServiceContext _context;
        public EmployeesController(RoleServiceContext context)
        {
            _context = context;
        }
        
        // GET api/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return _context.employees;
        }

        
        // GET api/employees/2
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = _context.employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }
            
            return employee;
        }
        
        
        // GET api/employees/2
        [HttpGet("GetEmployeeDetails/{id}")]
        public ActionResult<Employee> GetEmployeeDetails(int id)
        {
            var employee = _context.employees
                .Include(e => e.role).First(e => e.employee_id == id);

            if (employee == null)
            {
                return NotFound();
            }
            
            return employee;
        }

        
        // POST api/employees
        [HttpPost]
        public ActionResult<Employee> PostEmployee(Employee employee)
        {
            _context.employees.Add(employee);
            _context.SaveChanges();

            return CreatedAtAction("GetEmployee", new Employee { employee_id = employee.employee_id }, employee);
        }

        
        // PUT api/employees/2
        [HttpPut("{id}")]
        public ActionResult PutEmployee(int id, Employee employee)
        {
            if (id != employee.employee_id)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            
            return NoContent();
        }
        
        private bool EmployeeExists(int id)
        {
            return _context.employees.Any(e => e.employee_id == id);
        }

        
        // DELETE api/employees/2
        [HttpDelete("{id}")]
        public ActionResult<Employee> PutEmployee(int id)
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