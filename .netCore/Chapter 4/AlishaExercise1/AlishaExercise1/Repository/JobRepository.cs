using AlishaExercise1.Model;
using System.Collections.Generic;

namespace AlishaExercise1.Repository
{
    public class JobRepository
    {
        private readonly List<Job> jobs = new List<Job>();
        public List<Job> GetJobs() => jobs;
        public void AddJob(Job job) => jobs.Add(job);
    }
}

