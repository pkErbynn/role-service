using System.Collections.Generic;

namespace io.turntabl.RoleService.Models
{
    public class Role
    {
        public short role_id { get; set; }
        public short role_name { get; set; }
        public string role_description { get; set; }

        public virtual ICollection<Employee> employees { get; set; }
    }
}