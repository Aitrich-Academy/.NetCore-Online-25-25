using workshop_chap4.Model;
using System;
using System.Collections.Generic;

namespace workshop_chap4.Repository
{
    public class UserRepository
    {
        private readonly List<User> _users = new List<User>();

        public List<User> GetAll() => _users;

        public bool Register(User user)
        {
            if (_users.Exists(u => u.Email == user.Email))
                throw new Exception("User already exists!");

            _users.Add(user);
            return true;
        }

        public User? Login(string email, string password)
        {
            return _users.Find(u => u.Email == email && u.Password == password);
        }
    }
}
