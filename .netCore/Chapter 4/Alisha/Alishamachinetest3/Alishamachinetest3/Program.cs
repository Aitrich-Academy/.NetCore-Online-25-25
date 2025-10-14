namespace Alishamachinetest3
{
    abstract class LibraryMember
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public LibraryMember(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }
        public abstract double CalculateFine(int overdueDays);
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
        class program
        {
            static void main()
            {
                LibraryMember[] libraryMember = new LibraryMember[2];
                libraryMember[0] = new StudentMember(1, "Alisha");
                libraryMember[1] = new FacultyMember(2, "Reeshma");
                Console.WriteLine(libraryMember);
            }
        }
    }
    
}
