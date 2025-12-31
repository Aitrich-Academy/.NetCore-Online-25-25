using Microsoft.EntityFrameworkCore;
namespace EmployeeManagementActivity.Model
{
    public class ApplicationDBContext:DbContext
    {
       
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<EmployeeMgt> NewEmployees { get; set; }
    }
    
}
