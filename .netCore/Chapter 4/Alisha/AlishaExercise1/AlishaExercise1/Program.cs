using AlishaExercise1.Manager;
using AlishaExercise1.Repository;
using AlishaExercise1.Manager;
using AlishaExercise1.Repository;
using System;

namespace AlishaExercise1
{
    class Program
    {
        static void Main()
        {
            var userRepo = new UserRepository();
            var jobRepo = new JobRepository();
            var userManager = new UserManager(userRepo);
            var jobManager = new JobManager(jobRepo);

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                Console.Write("Choose any option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Please enter your email: ");
                    string email = Console.ReadLine();
                    Console.Write("Please enter your password: ");
                    string password = Console.ReadLine();

                    if (userManager.Login(email, password))
                    {
                        Console.WriteLine("Login successful!");
                        Console.WriteLine($"Welcome {email.Split('@')[0]}");

                        bool backToMain = false;
                        while (!backToMain)
                        {
                            Console.WriteLine("\nChoose an option:");
                            Console.WriteLine("1. Jobs");
                            Console.WriteLine("2. Logout");
                            string subChoice = Console.ReadLine();

                            if (subChoice == "1")
                            {
                                bool jobMenu = true;
                                while (jobMenu)
                                {
                                    Console.WriteLine("\nChoose an option:");
                                    Console.WriteLine("1. List jobs");
                                    Console.WriteLine("2. Post job");
                                    Console.WriteLine("3. Back to main menu");
                                    string jobChoice = Console.ReadLine();

                                    switch (jobChoice)
                                    {
                                        case "1": jobManager.ListJobs(); break;
                                        case "2": jobManager.PostJob(); break;
                                        case "3": jobMenu = false; break;
                                        default: Console.WriteLine("Invalid option."); break;
                                    }
                                }
                            }
                            else if (subChoice == "2")
                            {
                                Console.WriteLine("Logged out successfully.");
                                backToMain = true;
                            }
                            else Console.WriteLine("Invalid option.");
                        }
                    }
                    else Console.WriteLine("Invalid credentials. Try again.");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    if (userManager.Register(email, password))
                        Console.WriteLine("Registration successful!");
                    else
                        Console.WriteLine("User already exists.");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting application. Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
    }
}

