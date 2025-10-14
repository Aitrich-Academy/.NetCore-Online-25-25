using AlishaExercise1.Enums;
using AlishaExercise1.Enums;

namespace AlishaExercise1.Model
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public JobType Type { get; set; }
        public decimal SalaryRange { get; set; }

        public override string ToString()
        {
            return $"{JobId,-6} | {Title,-10} | {Description,-15} | {Company,-10} | {Location,-10} | {Type,-8} | {SalaryRange}";
        }
    }
}

