using MvcWorkshopHireMe.Models;

namespace MvcWorkshopHireMe.Interface
{
    public interface IUserService
    {
        User GetBiId(Guid guid);
    }
}
