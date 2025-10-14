using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Managers
{
    public class Printer
    {
        public void Print(Job[] jobs)
        {
            Console.WriteLine("\n Job Listings");
            foreach (var job in jobs)
            {
                Console.WriteLine($"[{job.Id}] {job.Title} | {job.Company} | {job.Location} | {job.Salary} | {job.Type}");
            }
        }
        public void Print(Application[] applications)
        {
            Console.WriteLine("\nApplications");
            foreach (var app in applications)
            {
                Console.WriteLine($"[{app.Id}] {app.Name} | {app.Location} | {app.Qualification} | {app.Experience}");
            }
        }
        public void Print(Interview[] interviews)
        {
            Console.WriteLine("\nInterviews");
            foreach (var interview in interviews)
            {
                Console.WriteLine($"[{interview.Id}] {interview.Company} | {interview.Post} | {interview.Date} | {interview.Time} | {interview.Location}");
            }
        }

    }
}
