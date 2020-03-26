using Microsoft.EntityFrameworkCore;


namespace io.turntabl.RoleService.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }
    }
}