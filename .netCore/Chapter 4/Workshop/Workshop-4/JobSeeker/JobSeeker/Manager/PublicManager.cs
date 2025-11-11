using System;
using System.Text.RegularExpressions;
using Admin_Job.Enums;
using workshop_chap4.Interfaces;
using workshop_chap4.Model;
using workshop_chap4.Repository;
using workshop_chap4.Exceptions;
using JobSeeker.Manager;

namespace workshop_chap4.Manager
{
    public class PublicManager : IMenu
    {
        private readonly UserRepository _userRepository = new UserRepository();
        public User LoggedUser = new User();
        private IMenu? menu;

        public void DisplayMenu()
        {
            ShowUserMenu();
        }

        private void ShowUserMenu()
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string? option1 = Console.ReadLine();
                switch (option1)
                {
                    case "1":
                        RegisterJobSeeker();
                        break;
                    case "2":
                        LoginJobSeeker();
                        break;
                    case "3":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        private void LoginJobSeeker()
        {
            string email = GetEmail();
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine() ?? string.Empty;

            User? user = _userRepository.Login(email, password);
            if (user != null)
            {
                LoggedUser = user;
                Console.WriteLine($"Login successful! Welcome {LoggedUser.FirstName}");
                if (LoggedUser.Role == Roles.JobSeeker)
                {
                    menu = new UserManager(LoggedUser);
                    menu.DisplayMenu();
                }
            }
            else
            {
                Console.WriteLine("Login failed. Try again.");
            }
        }

        private void RegisterJobSeeker()
        {
            User newUser = new User();
            Console.WriteLine("First name:");
            newUser.FirstName = Console.ReadLine();

            Console.WriteLine("Last name:");
            newUser.LastName = Console.ReadLine();

            newUser.Email = GetEmail();
            newUser.Phone = GetPhoneNumber();

            Console.WriteLine("Password:");
            newUser.Password = Console.ReadLine() ?? string.Empty;

            try
            {
                _userRepository.Register(newUser);
                Console.WriteLine("Registration successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string GetEmail()
        {
            while (true)
            {
                Console.WriteLine("Email:");
                string? email = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^\S+@\S+\.\S+$"))
                    return email;

                Console.WriteLine("Invalid email, try again...");
            }
        }

        private long GetPhoneNumber()
        {
            while (true)
            {
                Console.WriteLine("Phone number:");
                if (long.TryParse(Console.ReadLine(), out long phone))
                    return phone;

                Console.WriteLine("Invalid number, try again...");
            }
        }
    }
}
