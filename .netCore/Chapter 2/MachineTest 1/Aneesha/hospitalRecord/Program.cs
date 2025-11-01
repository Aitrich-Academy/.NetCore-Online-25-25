namespace hospitalRecord;

struct patient
{
  public  int ID;
  public  string Name;
  public  int Age;
}


class Program
{
    static void Main(string[] args)
    {

        patient[] patients = new patient[5];

        Console.WriteLine("Enter 5 patients details");

        for(int i=0; i<patients.Length;i++)

        {
            Console.WriteLine($"patient{i + 1}:");
            Console.Write("Enter ID:");
            patients[i].ID = int.Parse(Console.ReadLine());

            Console.Write("Enter Name:");
            patients[i].Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            patients[i].Age = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Patient Details");
        for (int i = 0; i < patients.Length; i++)
        {
            Console.WriteLine($"ID:{patients[i].ID},Name:{patients[i].Name},Age:{patients[i].Age}");
        }
        Console.ReadLine();
    }
}
  
