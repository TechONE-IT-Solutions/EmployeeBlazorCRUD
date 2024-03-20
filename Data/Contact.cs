using System.ComponentModel.DataAnnotations;

namespace EmployeeBlazorCRUD.Data
{
    public class ContactUS
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 10)]
        public string Message { get; set; }
    }
}
