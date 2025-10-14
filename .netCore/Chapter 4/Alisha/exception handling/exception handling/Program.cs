using System.Text.RegularExpressions;

namespace exception_handling
{
    public class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }
    }
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }
        public BankAccount(string accNumber, string accHolderName, decimal initialBalance)
        {
            AccountNumber = accNumber;
            AccountHolderName = accHolderName;
            Balance = initialBalance;
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public void DisplayAccountDetails()
        {
            Console.WriteLine("=== Account Details ===");
            Console.WriteLine($"Account Number     : {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Balance            : {Balance:C}");
        }
    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accNumber, string accHolderName, decimal initialBalance, decimal overdraftLimit)
            : base(accNumber, accHolderName, initialBalance) { }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}");
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance!");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}");
        }
    }
    class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string accNumber, string accHolderName, decimal initialBalance, decimal overdraftLimit)
            : base(accNumber, accHolderName, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} into CurrentAccount.");
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (Balance - amount < -OverdraftLimit)
            {
                Console.WriteLine("Withdrawal denied. Overdraft limit exceeded.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C} from CurrentAccount.");
        }
    }
    internal class Program
    {
        static List<BankAccount> accounts = new List<BankAccount>();
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n=== Banking System Menu ===");
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Account Details");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            CreateAccount();
                            break;
                        case "2":
                            DepositToAccount();
                            break;
                        case "3":
                            WithdrawFromAccount();
                            break;
                        case "4":
                            DisplayDetails();
                            break;
                        case "5":
                            exit = true;
                            Console.WriteLine("Exiting the application...");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (InvalidAmountException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }
        static void CreateAccount()
        {
            Console.Write("Enter Account Number: ");
            string accNumber = Console.ReadLine();
            Console.Write("Enter Account Holder Name: ");
            string accHolder = Console.ReadLine();
            Console.Write("Enter Initial Balance: ");
            decimal initialBalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Select Account Type: 1. Savings  2. Current");
            string type = Console.ReadLine();
            if (type == "1")
            {
                Console.Write("Enter Interest Rate (%): ");
                decimal interest = decimal.Parse(Console.ReadLine());
                accounts.Add(new SavingsAccount(accNumber, accHolder, initialBalance, interest));
                Console.WriteLine("Savings Account created successfully!");
            }
            else if (type == "2")
            {
                Console.Write("Enter Overdraft Limit: ");
                decimal overdraft = decimal.Parse(Console.ReadLine());
                accounts.Add(new CurrentAccount(accNumber, accHolder, initialBalance, overdraft));
                Console.WriteLine("Current Account created successfully!");
            }
            else
            {
                Console.WriteLine("Invalid account type.");
            }
        }
        static BankAccount FindAccount(string accNumber)
        {
            foreach (var acc in accounts)
            {
                if (acc.AccountNumber == accNumber)
                    return acc;
            }
            Console.WriteLine("Account not found.");
            return null;
        }
        static void DepositToAccount()
        {
            Console.Write("Enter Account Number: ");
            string accNumber = Console.ReadLine();
            var account = FindAccount(accNumber);
            if (account != null)
            {
                Console.Write("Enter Deposit Amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                account.Deposit(amount);
            }
        }
        static void WithdrawFromAccount()
        {
            Console.Write("Enter Account Number: ");
            string accNumber = Console.ReadLine();
            var account = FindAccount(accNumber);
            if (account != null)
            {
                Console.Write("Enter Withdraw Amount: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                account.Withdraw(amount);
            }
        }
        static void DisplayDetails()
        {
            foreach (var acc in accounts)
            {
                acc.DisplayAccountDetails();
            }
        }
    }
}