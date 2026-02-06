using MvcWorkshopHireMe.Interface;
using MvcWorkshopHireMe.Models;

namespace MvcWorkshopHireMe.Services
{
    public class UserService:IUserService
        {

        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public User GetBiId(Guid guid)
        {
            return repository.getById(guid);
        }
    }
}

