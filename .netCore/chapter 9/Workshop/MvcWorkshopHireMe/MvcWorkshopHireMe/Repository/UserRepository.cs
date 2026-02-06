using Microsoft.EntityFrameworkCore;
using MvcWorkshopHireMe.Enums;
using MvcWorkshopHireMe.Interface;
using MvcWorkshopHireMe.Models;

namespace MvcWorkshopHireMe.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly AppDbContext _context;

        private static User loggedUser = new User();

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User getById(Guid userid)
        {
            User user = _context.Users.Where(e => e.Id == userid).Include(x => x.Skills)
                .Include(x => x.Experiences).Include(x => x.Qualifications).IgnoreAutoIncludes().FirstOrDefault();

            return user;
        }


        public User login(string email, string password)
        {
            loggedUser = _context.Users.Where(e => e.Email == email && e.password == password).FirstOrDefault();
            return loggedUser;
        }
        //public User login(string email, string password)
        //{
        //    return _context.Users.FirstOrDefault(e => e.Email == email && e.password == password);
        //}


        public User getLoggedUser()
        {
            return loggedUser;
        }


        public User register(User user)
        {
            user.Role = Roles.JobProvider;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}

