using Microsoft.EntityFrameworkCore;

namespace role_api.Models
{
    public class RoleContext : DbContext
    {
        public RoleContext(DbContextOptions<RoleContext> options) : base(options) { }
        public DbSet<Role> Roles { get; set; }
    }
}