using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop2.Enums;

namespace workshop2.Models
{
    internal class JobSeeker
    {
        int AppliedJobCount = 0;
        int SavedJobCount = 0;
        private Job[] AppliedJobs = new Job[10];
        private Job[] SavedJobs =new Job[10];
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Password {  get; set; }
        public void addAppliedJob(Job job)
        {
            if (AppliedJobCount < 10)
            {
                AppliedJobs[AppliedJobCount] = job;
                AppliedJobCount++;
            }
            else
            {
                Console.WriteLine("job apply limit exeeds...");
            }
        }
        public Job[] GetAppliedJobs()
        {
            return AppliedJobs;
        }
        public void addSavedJob(Job job)
        {
            if(SavedJobCount < 10)
            {
                SavedJobs[SavedJobCount] = job;
                SavedJobCount++;
                Console.WriteLine("job saved successfully...");
            }
            else
            {
                Console.WriteLine("saved jobs limit exeeds");
            }
        }
        public Job[] GetSavedJobs() 
        {
            return SavedJobs;
        }


    }
}
