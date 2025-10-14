namespace encapsulation
{
    //Student Marks
    class Student
    {
        private int marks;
        private string name;
        public int Marks
        {
            get { return marks; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("marks cannot be negative or more than 100.");
                else
                {
                    marks = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("name cannot be empty.");
                else
                    name = value;
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Marks: {marks}");
        }
    }
    //Bank Account
    class BankAccount
    {
        private string accountNumber;
        private double balance;
        public BankAccount(string accNo, double initialBalance)
        {
            accountNumber = accNo;
            balance = initialBalance >= 0 ? initialBalance : 0;
        }
        public string AccountNumber
        {
            get { return accountNumber; }
        }
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. New Balance: {balance}");
            }
        }
    }




    //Employee Salary
    class Employee
    {
        private string name;
        private double basicSalary;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Name cannot be empty.");
                else
                    name = value;
            }
        }
        public double BasicSalary
        {
            get { return basicSalary; }
            set
            {
                if (value > 5000)
                    basicSalary = value;
                else
                    Console.WriteLine("Basic Salary must be greater than 5000.");
            }
        }
        public double CalculateNetSalary()
        {
            return basicSalary + (0.10 * basicSalary);
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}, Basic Salary: {basicSalary}, Net Salary: {CalculateNetSalary()}");
        }
    }


    // Car Speed Control
    class Car
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0 && value <= 200)
                    speed = value;
                else
                    Console.WriteLine("Invalid speed! Must be between 0 and 200.");
            }
        }
        public void Accelerate()
        {
            if (speed + 10 <= 200)
            {
                speed += 10;
                Console.WriteLine($"Accelerated: Speed = {speed}");
            }
            else
            {
                Console.WriteLine("Cannot accelerate. Maximum speed reached!");
            }
        }
        public void Brake()
        {
            if (speed - 10 >= 0)
            {
                speed -= 10;
                Console.WriteLine($"Braked: Speed = {speed}");
            }
            else
            {
                Console.WriteLine("Cannot brake. Minimum speed is 0.");
            }
        }


    }


    //Library Book
    class Book
    {
        private string title;
        private string author;
        private double price;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Title cannot be empty.");
                else
                    title = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Author cannot be empty.");
                else
                    author = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    Console.WriteLine("Price must be greater than 0.");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
   

    //ATM Machine Simulation




    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Name = "Alisha";
            //student.Marks = 70;       
            //student.DisplayDetails();
            //student.Name = "Aneesha";         
            //student.Marks = 85;      
            //student.DisplayDetails();


            //BankAccount acc1 = new BankAccount("ACC123", 5000);
            //Console.WriteLine($"Account Number: {acc1.AccountNumber}");
            //Console.WriteLine($"Initial Balance: {acc1.Balance}");
            //acc1.Deposit(2000);
            //acc1.Withdraw(1500);
            //acc1.Withdraw(7000);
            //acc1.Deposit(100);


            //Employee emp1 = new Employee();
            //emp1.Name = "Alisha";
            //emp1.BasicSalary = 8000;
            //emp1.DisplayDetails();
            //emp1.Name = "Anna";        
            //emp1.BasicSalary = 3000;
            //emp1.DisplayDetails();


            //Book book = new Book();
            //book.Title = "hdfhjhk";
            //book.Author = "kjutgoik";
            //book.Price = 45;
            //book.DisplayDetails();


            Car myCar = new Car();
            myCar.Speed = 50;
            Console.WriteLine($"Initial Speed: {myCar.Speed}");
            myCar.Accelerate();
            myCar.Accelerate(); 
            myCar.Brake();
            myCar.Speed = 250; 
            myCar.Speed = 20;



        }
    }
}
