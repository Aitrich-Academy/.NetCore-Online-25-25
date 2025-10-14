using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Interfaces
{
    public interface IJobProvider
    {
        void PostJob(Job job);     
        Job[] GetJobs();
    }
}
