using EmployeeBlazorCRUD.DataContext;
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


        //  GET ALL EMPLOYEES
        public async Task<List<Employee>> GetEmployees()
        {
            return await applicationDbContext.Employees.ToListAsync();
        }

        // ADD AN EMPLOYEE
        public async Task<bool> AddEmployee(Employee employee)
        {
            try
            {
                applicationDbContext.Employees.Add(employee);
                await applicationDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //  DELETE EMPLOYEE BY ID
        public async Task<bool> TrashEmployee(int id)
        {
            try
            {
                var EmployeeToDelete = await applicationDbContext.Employees.FindAsync(id);
                if (EmployeeToDelete == null)
                {
                    return false;
                }
                applicationDbContext.Employees.Remove(EmployeeToDelete);
                await applicationDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // UPDATE THE EMPLOYEE RECORD
        public async Task<bool> UpdateEmployeeRecord(Employee employee)
        {
            try
            {
                applicationDbContext.Entry(employee).State = EntityState.Modified;
                await applicationDbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
