using System;
using System.Collections.Generic;
using workshop_chap4.Model;

namespace workshop_chap4.Repository
{
    public class UserRepository
    {
        private readonly List<User> users = new();

        public User? Login(string email, string password)
        {
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                    return user;
            }
            return null;
        }

        public bool Register(User newUser)
        {
            foreach (var user in users)
            {
                if (user.Email == newUser.Email)
                    throw new Exception("User already exists with this email");
            }

            users.Add(newUser);
            return true;
        }

        public List<User> GetAll()
        {
            return users;
        }
    }
}
