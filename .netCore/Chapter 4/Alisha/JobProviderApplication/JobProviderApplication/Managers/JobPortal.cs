using JobProviderApplication.Interfaces;
using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Managers
{
    public class JobPortal : IJobProvider, IApplicationProvider, IInterviewProvider
    {
        private Job[] jobs = new Job[10];
        private Application[] applications = new Application[10];
        private Interview[] interviews = new Interview[10];
        private int jobCount = 0;
        private int appCount = 0;
        private int intCount = 0;
        public void PostJob(Job job)
        {
            if (jobCount < jobs.Length)
                jobs[jobCount++] = job;
        }
        public Job[] GetJobs()
        {
            Job[] result = new Job[jobCount];
            for (int i = 0; i < jobCount; i++) result[i] = jobs[i];
            return result;
        }
        public void AddApplication(Application application)
        {
            if (appCount < applications.Length)
                applications[appCount++] = application;
        }
        public Application[] GetApplications()
        {
            Application[] result = new Application[appCount];
            for (int i = 0; i < appCount; i++) result[i] = applications[i];
            return result;
        }
        public void ScheduleInterview(Interview interview)
        {
            if (intCount < interviews.Length)
                interviews[intCount++] = interview;
        }
        public Interview[] GetInterviews()
        {
            Interview[] result = new Interview[intCount];
            for (int i = 0; i < intCount; i++) result[i] = interviews[i];
            return result;
        }
    }
}
        
    

