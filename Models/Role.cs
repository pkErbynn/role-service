using System.ComponentModel.DataAnnotations;

namespace io.turntabl.RoleService.Models
{
    public class Role
    {
        [Key]
        public int role_id{get; set;}
        public string role_name { get; set; }
        public string role_description { get; set; }
        
        public  int employee_id { get; set; }
        public Employee employee { get; set; }
    }
}