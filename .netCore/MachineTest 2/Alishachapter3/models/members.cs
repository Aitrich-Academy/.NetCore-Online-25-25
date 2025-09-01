using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alishachapter3.models
{
    class StudentMember : LibraryMember
    {
        public StudentMember(int memberId, string name) : base(memberId, name) { }

        private double FinePerDay = 1;
        public override double CalculateFine(int overdueDays)
        {
            return overdueDays * FinePerDay;
        }
    }
    class FacultyMember : LibraryMember
    {
        public FacultyMember(int memberId, string name) : base(memberId, name) { }

        private double FinePerDay = 0.5;
        public override double CalculateFine(int overdueDays)
        {
            return overdueDays * FinePerDay;
        }
    }
}
