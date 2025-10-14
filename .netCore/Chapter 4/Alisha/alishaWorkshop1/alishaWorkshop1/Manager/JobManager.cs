using alishaWorkshop1.Interface;
using alishaWorkshop1.Interface;
using alishaWorkshop1.Models;
using alishaWorkshop1.Interface;
using alishaWorkshop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alishaWorkshop1.Manager
{
    public class JobManager : IJobProvider
    {
        private List<Job> jobs = new List<Job>();
        public void PostJob(Job job)
        {
            job.Id = jobs.Count;
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }


    }
}

