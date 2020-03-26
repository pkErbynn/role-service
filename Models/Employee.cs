using System.ComponentModel.DataAnnotations;

namespace io.turntabl.RoleService.Models
{
    public class Employee
    {
        [Key]
        public int employeeid{get; set;}
        public string employeefname { get; set; }
        public string employeelname { get; set; }
        public string employeeemail { get; set; }
        public string employeeaddress { get; set; }
        public string employeerole { get; set; }
    }
}