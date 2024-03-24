using EmployeeBlazorCRUD.DataContext;
using EmployeeBlazorCRUD.Pages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBlazorCRUD.Data
{
    public class ContactService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ContactService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task AddNewContact(Contact contact)
        {
            applicationDbContext.Contacts.Add(contact);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}

