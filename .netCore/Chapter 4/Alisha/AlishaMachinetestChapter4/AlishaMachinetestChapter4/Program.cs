using AlishaMachinetestChapter4.Exceptions;
using AlishaMachinetestChapter4.Managers;
using AlishaMachinetestChapter4.Enums;
using AlishaMachinetestChapter4.Models;
using System.Security.Principal;


namespace AlishaMachinetestChapter4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n........Bank Account Management System........");
                Console.WriteLine("\n1. Create a new bank account");
                Console.WriteLine("\n2. Remove an account ");
                Console.WriteLine("\n3. Deposit money");
                Console.WriteLine("\n4. Withdraw money");
                Console.WriteLine("\n5. Check balance");
                Console.WriteLine("\n6. Exist");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Account number : ");
                            int accountNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter name : ");
                            string name = Console.ReadLine();
                            Console.WriteLine("enter account type : ");
                            AccountType type=(AccountType)int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter balance : ");
                            decimal balance = decimal.Parse(Console.ReadLine());
                            bank.AddAccount(new BankAccount(accountNumber, name, balance, type));
                            Console.WriteLine("Account created");
                            break;
                        case 2:
                            Console.WriteLine("Enter Account number to remove : ");
                            accountNumber = int.Parse(Console.ReadLine());
                            bank.RemoveAccount(accountNumber);
                            Console.WriteLine("Account Removed");
                            break;
                        case 3:
                            Console.WriteLine("Enter account number : ");
                            accountNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter deposit amount : ");
                            decimal dep = decimal.Parse(Console.ReadLine());
                            bank.GetAccount(accountNumber).Deposit(dep);
                            Console.WriteLine("Deposit successful");
                            break;
                        case 4:
                            Console.WriteLine("Enter account number : ");
                            accountNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter withdraw amount : ");
                            decimal wd = decimal.Parse(Console.ReadLine());
                            bank.GetAccount(accountNumber).Withdraw(wd);
                            Console.WriteLine("withdrawal successful");
                            break;
                        case 5:
                            Console.WriteLine("Enter account number : ");
                            accountNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine(bank.GetAccount(accountNumber));

                            break;
                        case 6:
                            running = false;
                            Console.WriteLine("Exist");
                            break;
                    }
                }
                catch (AccountDoesNotExistException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(InsufficientBalanceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
