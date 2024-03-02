namespace EmployeeBlazorCRUD.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; } = "Male"; // default value

        public Employee Clone()
        {
            return new Employee
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Gender = this.Gender,
            };
        }
    }
}
