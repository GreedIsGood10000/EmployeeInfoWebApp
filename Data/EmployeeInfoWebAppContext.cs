using Microsoft.EntityFrameworkCore;

namespace EmployeeInfoWebApp.Models
{
    //Domain model
    public class EmployeeInfoWebAppContext : DbContext
    {
        public EmployeeInfoWebAppContext (DbContextOptions<EmployeeInfoWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeInfoWebApp.Models.EmployeeInfo> EmployeeInfo { get; set; }
    }
}
