using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace io.turntabl.RoleService.Models
{
    public class RoleServiceContext : DbContext
    {
        public RoleServiceContext(DbContextOptions<RoleServiceContext> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Role> roles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Employee>().Property(employee => employee.role).IsRequired();
            
            builder.Entity<Role>()
                .HasMany(p => p.employees)
                .WithOne(p => p.role)
                .HasForeignKey(p => p.role_id);
        }
    }
}