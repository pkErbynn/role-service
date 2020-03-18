using Microsoft.EntityFrameworkCore;


namespace io.turntabl.RoleService.Models
{
    public class RoleContext : DbContext
    {
        public RoleContext(DbContextOptions<RoleContext> options) : base(options) { }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Role> Role { get; set; }

    }
}