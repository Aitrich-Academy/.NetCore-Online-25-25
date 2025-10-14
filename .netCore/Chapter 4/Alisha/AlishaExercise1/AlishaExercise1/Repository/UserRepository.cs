using System.Collections.Generic;

namespace AlishaExercise1.Repository
{
    public class UserRepository
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>();

        public bool Register(string email, string password)
        {
            if (users.ContainsKey(email)) return false;
            users[email] = password;
            return true;
        }

        public bool Validate(string email, string password)
        {
            return users.ContainsKey(email) && users[email] == password;
        }
    }
}

