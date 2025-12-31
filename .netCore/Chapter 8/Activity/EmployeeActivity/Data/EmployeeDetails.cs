namespace EmployeeActivity.Data
{
    public class EmployeeDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public long PhoneNo { get; set; }
        public EmployeeDetails() { }
        public EmployeeDetails(int id, string firstName, string lastName, string email, long phoneno)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNo = phoneno;

        }

    }
}
