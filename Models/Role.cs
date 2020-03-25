using System.ComponentModel.DataAnnotations;

namespace io.turntabl.RoleService.Models
{
    public class Role
    {
        public int Id{get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
    }
}