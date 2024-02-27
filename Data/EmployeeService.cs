using EmployeeBlazorCRUD.DataContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EmployeeService(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }


        
        public async Task<List<Employee>> GetEmployees()
        {
            return await applicationDbContext.Employees.ToListAsync();
        }
    }
}
