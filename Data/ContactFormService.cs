using EmployeeBlazorCRUD.DataContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeBlazorCRUD.Data
{
    public class ContactFormService(ApplicationDbContext applicationDbContext)
    {
        private readonly ApplicationDbContext applicationDbContext = applicationDbContext;

        // Add a contact form
        public async Task<bool> AddContactForm(ContactUS contactusform)
        {
            try
            {
                applicationDbContext.Contacts.Add(contactusform);
                await applicationDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
