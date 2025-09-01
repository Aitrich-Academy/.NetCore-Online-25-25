using Alishachapter3.models;
        class program
        {
            static void Main()
            {
                int overdueDays = 2;
                LibraryMember[] libraryMember = new LibraryMember[2];
        {
            libraryMember[0] = new StudentMember(1, "Alisha");
            libraryMember[1] = new FacultyMember(2, "Reeshma");
        }
        foreach (var member in libraryMember)
        {

            Console.WriteLine($"{member.Name}-Fine is {member.CalculateFine(overdueDays)}");
        }

            }
        }
    



