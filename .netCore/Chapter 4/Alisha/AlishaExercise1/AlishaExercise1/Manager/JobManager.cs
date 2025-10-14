using AlishaExercise1.Enums;
using AlishaExercise1.Model;
using AlishaExercise1.Enums;
using AlishaExercise1.Model;
using AlishaExercise1.Repository;
using System;
using System.Linq;

namespace AlishaExercise1.Manager
{
    public class JobManager
    {
        private readonly JobRepository repo;
        public JobManager(JobRepository repository) => repo = repository;

        public void ListJobs()
        {
            var jobs = repo.GetJobs();
            if (!jobs.Any())
            {
                Console.WriteLine("No jobs available.");
                return;
            }

            Console.WriteLine("JobId | Title      | Description      | Company    | Location   | JobType  | SalaryRange");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            foreach (var job in jobs)
                Console.WriteLine(job);
        }

        public void PostJob()
        {
            Console.Write("Enter JobId: ");
            int jobId = int.Parse(Console.ReadLine());
            Console.Write("Enter Job title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Job description: ");
            string desc = Console.ReadLine();
            Console.Write("Enter Job location: ");
            string location = Console.ReadLine();
            Console.Write("Enter Job type : ");
            JobType type = (JobType)int.Parse(Console.ReadLine());
            Console.Write("Enter Job salary range: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Job company: ");
            string company = Console.ReadLine();

            repo.AddJob(new Job
            {
                JobId = jobId,
                Title = title,
                Description = desc,
                Location = location,
                Type = type,
                SalaryRange = salary,
                Company = company
            });

            Console.WriteLine("Job posted successfully.");
        }
    }
}

