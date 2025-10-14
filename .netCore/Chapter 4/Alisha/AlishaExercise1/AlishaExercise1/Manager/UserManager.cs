using AlishaExercise1.Repository;

namespace AlishaExercise1.Manager
{
    public class UserManager
    {
        private readonly UserRepository repo;

        public UserManager(UserRepository repository)
        {
            repo = repository;
        }

        public bool Register(string email, string password) => repo.Register(email, password);
        public bool Login(string email, string password) => repo.Validate(email, password);
    }
}

