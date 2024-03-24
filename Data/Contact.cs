namespace EmployeeBlazorCRUD.Data

{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        public Contact Clone()
        {
            return new Contact
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                Phone = this.Phone,
                Message = this.Message,
            };
        }

    }

    
}

