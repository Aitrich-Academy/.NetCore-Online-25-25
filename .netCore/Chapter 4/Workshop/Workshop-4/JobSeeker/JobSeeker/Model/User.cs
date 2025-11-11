
using Admin_Job.Enums;

namespace workshop_chap4.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = string.Empty;
        public long Phone { get; set; }
        public string Password { get; set; } = string.Empty;
        public Roles Role { get; set; }

        public User() { }

        public User(int id, string firstName, string lastName, string email, long phone, string password, Roles role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Password = password;
            Role = role;
        }
    }
}
