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


        // Get All
        public async Task<List<Employee>> GetEmployees()
        {
            return await applicationDbContext.Employees.ToListAsync();
        }

        // Save Data
        public async Task<bool> AddEmployees( Employee employee)
        {
            await applicationDbContext.Employees.AddAsync(employee);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }

        // BY id
        public async Task<Employee> GetEmployeesById(int id)
        {
            Employee employee =  await applicationDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return employee;
        }

        // BY id
        public async Task<bool> UpdateEmployees(Employee employee)
        {
            applicationDbContext.Employees.Update(employee);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }


        // Delete
        public async Task<bool> DeleteEmployees(Employee employee)
        {
            applicationDbContext.Employees.Remove(employee);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }


    }
}
