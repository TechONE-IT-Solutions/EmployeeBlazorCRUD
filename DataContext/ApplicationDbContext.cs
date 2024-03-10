using EmployeeBlazorCRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBlazorCRUD.DataContext
{
    public class ApplicationDbContext  : DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<ContactUS> Contacts { get; set; }
    }
}
