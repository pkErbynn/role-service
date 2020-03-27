using Microsoft.EntityFrameworkCore;


namespace io.turntabl.RoleService.Models
{
    public class RoleServiceContext : DbContext
    {
        public RoleServiceContext(DbContextOptions<RoleServiceContext> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Role> roles { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Student>()
                .HasRequired<Grade>(s => s.CurrentGrade)
                .WithMany(g => g.Students)
                .HasForeignKey<int>(s => s.CurrentGradeId);          }
    
    }
}