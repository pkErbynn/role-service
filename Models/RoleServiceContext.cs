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
            
            builder.Entity<Role>().ToTable("roles");
            builder.Entity<Role>().HasKey(p => p.role_id);
            builder.Entity<Role>().Property(p => p.role_id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Role>().Property(p => p.role_name).IsRequired();
            builder.Entity<Role>().Property(p => p.role_description).IsRequired();
            
            // table relationship
            builder.Entity<Role>()
                .HasMany(p => p.employees)
                .WithOne(p => p.role)
                .HasForeignKey(p => p.role_id);
            
            builder.Entity<Employee>().ToTable("employees");
            builder.Entity<Employee>().HasKey(p => p.employee_id);
            builder.Entity<Employee>().Property(p => p.employee_id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Employee>().Property(p => p.employee_fname).IsRequired();
            builder.Entity<Employee>().Property(p => p.employee_lname).IsRequired();
            builder.Entity<Employee>().Property(p => p.employee_email).IsRequired();
            builder.Entity<Employee>().Property(p => p.employee_address).IsRequired();
            
            // builder.Entity<Employee>()
            //     .HasOne(p => p.role)
            //     .WithMany(p => p.employees)
            //     .HasForeignKey(p => p.role_id);
            
            base.OnModelCreating(builder);

        }
    }
}