using oop;
using System.Xml.Linq;

namespace oop
{
    //.................Create a Student class................................
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("Student Name: " + Name);
        }
    }
}


//.....................Car class.................
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
}


//....................Rectangle area......................
class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
    public Rectangle()
    {

    }     
   
        public double GetArea()
        {
            return Length * Width;
        }
    }

//..........Bank Account class...........
class Bank
{
    public int AccountNumber;
    public string HolderName;
    public double Balance;

public Bank(int number, string name, double balance)
    {
        AccountNumber = number;
        HolderName = name;
        Balance = balance;
    }
    public void deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"deposited:"+amount);
    }
    
       public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. Remaining Balance = {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }
    public void Display()
    {
        Console.WriteLine($"Account No: {AccountNumber}, Name: {HolderName}, Balance: {Balance}");
    }
}
//.............................Employee salary.................................
class Employee
{
    public string Name; 
    public double BasicSalary; 
    public Employee(string name, double basicSalary)
    {
        Name = name;
        BasicSalary = basicSalary;
    }
    public double CalculateAnnualSalary()
    {
        return BasicSalary * 12;
    }
    public void Display()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Monthly Salary: {BasicSalary}");
        Console.WriteLine($"Annual Salary: {CalculateAnnualSalary()}");
    }
}
//..........................Product discount....................................
class Product
{
    public string ProductName;
    public double Price;
    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
    }
    public void ApplyDiscount(double percent)
    {
        if (percent > 0 && percent <= 100)
        {
            double discountAmount = Price * (percent / 100);
            Price -= discountAmount;
            Console.WriteLine($"Discount of {percent}% applied. New Price = {Price}");
        }
        else
        {
            Console.WriteLine("Invalid discount percentage!");
        }
    }
    public void Display()
    {
        Console.WriteLine($"Product: {ProductName}, Price: {Price}");
    }
}


//..........................Flight ticket booking....................................
class Ticket
{
    public string PassengerName; 
    public string FlightNumber;
    public double Price;
    public Ticket(string passengerName, string flightNumber, double price)
    {
        PassengerName = passengerName;
        FlightNumber = flightNumber;
        Price = price;
    }
    public void ApplyLuggageFee(double weight)
    {
        if (weight > 15)
        {
            double extraWeight = weight - 15;
            double extraCharge = extraWeight * 100;
            Price += extraCharge;
            Console.WriteLine($"Luggage overweight! Extra fee = {extraCharge}. New Price = {Price}");
        }
        else
        {
            Console.WriteLine("No extra luggage fee applied.");
        }
    }
    public void Display()
    {
        Console.WriteLine($"Passenger: {PassengerName}, Flight: {FlightNumber}, Ticket Price: {Price}");
    }
}

class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Item(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    public double GetTotal()
    {
        return Price * Quantity;
    }
}
class Cart
{
    private List<Item> items = new List<Item>();
    public void AddItem(Item item)
    {
        items.Add(item);
    }
    public void DisplayBill()
    {
        double grandTotal = 0;
        Console.WriteLine("------ Shopping Cart ------");
        foreach (var item in items)
        {
            double total = item.GetTotal();
            Console.WriteLine($"{item.Name}  x{item.Quantity}  @ {item.Price} = {total}");
            grandTotal += total;
        }
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Total Bill: {grandTotal}");
    }
}






class Program
    {
        static void Main(string[] args)
        {




        //Student student1 = new Student(1, "alisha");
        //student1.DisplayDetails();
        //Console.ReadLine();

        //Car car1 = new Car("Toyota", "Camry", 2020);
        //Car car2 = new Car("Honda", "Civic", 2022);
        //car1.DisplayDetails();
        //car2.DisplayDetails();

        //Console.ReadLine();
        //Rectangle rect = new Rectangle(3, 2);
        //Console.WriteLine("Area of Rectangle: " + rect.GetArea());
        //Console.ReadLine();


        //Bank account = new Bank(101, "Alisha", 5000);
        //account.Display();
        //account.deposit(2000);
        //account.Withdraw(1500);
        //account.Display();
        //Console.ReadLine();

        //Employee emp = new Employee("Alisha", 234);
        //emp.Display();
        //Console.ReadLine();


        //Product product = new Product("Mobile", 50000);
        //product.Display();
        //product.ApplyDiscount(7);
        //product.Display();
        //Console.ReadLine();

        //Ticket t1 = new Ticket("Alisha", "AI202", 5000);
        //Ticket t2 = new Ticket("Aneesha", "AI305", 6000);
        //t1.Display();
        //t2.Display();
        //t1.ApplyLuggageFee(12);
        //t2.ApplyLuggageFee(20);
        //t1.Display();
        //t2.Display();
        //Console.ReadLine();


        Cart cart = new Cart();
        cart.AddItem(new Item("Apple", 10.5, 3));
        cart.AddItem(new Item("Milk", 40, 2));
        cart.AddItem(new Item("Bread", 25, 1));
        cart.DisplayBill();







    }
}







