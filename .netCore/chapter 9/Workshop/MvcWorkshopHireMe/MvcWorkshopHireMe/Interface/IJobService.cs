using MvcWorkshopHireMe.Models;

namespace MvcWorkshopHireMe.Interface
{
    public interface IJobService
    {
        public List<Job> GetJobs();

        public List<Job> GetJobPosted(Guid cmpid);
    }
}
