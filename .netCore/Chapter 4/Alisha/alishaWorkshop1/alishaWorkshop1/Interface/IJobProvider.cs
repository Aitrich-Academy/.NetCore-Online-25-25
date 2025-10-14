
using alishaWorkshop1.Models;
using alishaWorkshop1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alishaWorkshop1.Interface
{
    public interface IJobProvider
    {
        void PostJob(Job job);
        List<Job> GetJobs();

    }
}

