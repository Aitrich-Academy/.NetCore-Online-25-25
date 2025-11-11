using System.Diagnostics.CodeAnalysis;

namespace AlishaMachinetest
{
    internal class Program
    {
        struct student
        {
            public int RollNo;
            public string Name;
            public int[] Grade;
        }
        static void Main(string[] args)
        {
            student[] students = new student[3];

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Enter Roll number : ");
                students[i].RollNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the name : ");
                students[i].Name = Console.ReadLine();

                students[i].Grade = new int[5];
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter the Grade {j+1} : ");
                    students[i].Grade[j] = Convert.ToInt32(Console.ReadLine());
                    
                    sum = sum + students[i].Grade[j];
                }
                
                double average = sum / 5;
                Console.WriteLine($"Average : {average} ");

            }













        }
    }
}
