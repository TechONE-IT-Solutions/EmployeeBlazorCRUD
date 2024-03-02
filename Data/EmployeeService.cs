using EmployeeBlazorCRUD.DataContext;
using EmployeeBlazorCRUD.Pages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBlazorCRUD.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EmployeeService(ApplicationDbContext applicationDbContext) 
        {
            this.applicationDbContext = applicationDbContext;
        }


        
        public async Task<List<Employee>> GetEmployees()
        {
            return await applicationDbContext.Employees.ToListAsync();
        }

        public async Task AddNewEmployee(Employee employee)
        {
            applicationDbContext.Employees.Add(employee);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateEmployee(Employee employee)
        {
            var existingEmployee = await applicationDbContext.Employees.FindAsync(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Gender = employee.Gender;

                await applicationDbContext.SaveChangesAsync();
            }
        }


        public async Task DeleteEmployee(int id)
        {
            var employee = await applicationDbContext.Employees.FindAsync(id);
            if (employee != null)
            {
                applicationDbContext.Employees.Remove(employee);
                await applicationDbContext.SaveChangesAsync();
            }
            
        }
    }
}
