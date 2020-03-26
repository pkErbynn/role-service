using System.ComponentModel.DataAnnotations;

namespace io.turntabl.RoleService.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId{get; set;}
        public string EmployeeFname { get; set; }
        public string EmployeeLname { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeRole { get; set; }
    }
}