using System.ComponentModel.DataAnnotations;

namespace io.turntabl.RoleService.Models
{
    public class Employee
    {
        [Key]
        public int employee_id{get; set;}
        public string employee_fname { get; set; }
        public string employee_lname { get; set; }
        public string employee_email { get; set; }
        public string employee_address { get; set; }
        
        public virtual Role role { get; set; }
    }
}