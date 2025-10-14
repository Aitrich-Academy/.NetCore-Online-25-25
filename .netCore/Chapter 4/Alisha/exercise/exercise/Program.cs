using System;

namespace exercise
{
    internal class Program
    {
        struct CompanyMember
        {
            public int UserId;
            public string Name;
            public string Designation;
            public string Email;
            public string Phone;
        }

        static void Main(string[] args)
        {
            CompanyMember[] members = new CompanyMember[10];
            int count = 0;

            Console.WriteLine("Welcome to the Hire Me Now Job portal!");
            Console.WriteLine("1. Login");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Please enter your email: ");
                string email = Console.ReadLine();

                Console.Write("Please enter your password: ");
                string password = Console.ReadLine();

                Console.WriteLine("Login successful!\n");

                int choice;
                do
                {
                    Console.WriteLine("1. List all company members");
                    Console.WriteLine("2. Add company member");
                    Console.WriteLine("3. Logout");

                    Console.Write("Enter your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.\n");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nCompany Members:\n");
                            Console.WriteLine("UserId\t| Name\t\t| Designation\t\t| Email\t\t\t| Phone");
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"{members[i].UserId}\t| {members[i].Name}\t| {members[i].Designation}\t| {members[i].Email}\t| {members[i].Phone}");
                            }
                            if (count == 0)
                            {
                                Console.WriteLine("No members available.");
                            }
                            Console.WriteLine();
                            break;

                        case 2:
                            if (count < members.Length)
                            {
                                members[count].UserId = count + 1;

                                Console.Write("Please enter company member name: ");
                                members[count].Name = Console.ReadLine();

                                Console.Write("Please enter email: ");
                                members[count].Email = Console.ReadLine();

                                Console.Write("Please enter designation: ");
                                members[count].Designation = Console.ReadLine();

                                Console.Write("Please enter phone number: ");
                                members[count].Phone = Console.ReadLine();

                                Console.WriteLine("Registration successful!\n");
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Member limit reached. Cannot add more.\n");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Logged out.\n");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.\n");
                            break;
                    }

                } while (choice != 3);
            }
            
        }
    }
}
