using Microsoft.EntityFrameworkCore;

namespace role_api.Models
{
    public class RoleContext : DbContext
    {

        public RoleContext(DbContextOptions<Role> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }
    }
}