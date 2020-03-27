using Microsoft.EntityFrameworkCore;


namespace io.turntabl.RoleService.Models
{
    public class RoleServiceContext : DbContext
    {
        public RoleServiceContext(DbContextOptions<RoleServiceContext> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Role> roles { get; set; }
        
    }
}