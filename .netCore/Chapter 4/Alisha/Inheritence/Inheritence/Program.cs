using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Inheritence
{
    internal class Program
    {
        //Display student details
        class person
        {
            public string Name;
            public int Age;

            public void displayPerson()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"age:{Age} ");
            }
        }
        class student:person
        {
            public int RollNo;
            public string course;
            public void displayStudent()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"roll no: {RollNo}");
                Console.WriteLine($"course : {course}");
            }
        }

        // calculate interest in bank
        class BankAccount
        {
            public int AccountNumber; 
            public double Balance;
            public BankAccount(int accountNumber, double balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }
            public void DisplayAccountDetails()
            {
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Balance: " + Balance);
            }
        }
        class SavingsAccount : BankAccount
        {
            public double InterestRate;
            public SavingsAccount(int accountNumber, double balance, double interestRate) : base(accountNumber, balance)


            {
                InterestRate = interestRate;
        }
            public void DisplaySavingsDetails()
            {
                DisplayAccountDetails();
                Console.WriteLine("Interest Rate: " + InterestRate + "%");
            }
        }

        // teacher and headteacher details
        class Teacher
        {
            public string Name;
            public string Subject;
            public Teacher(string name, string subject)
            {
                Name = name;
                Subject = subject;
            }
            public void DisplayTeacherDetails()
            {
                Console.WriteLine("Name : "+Name);
                Console.WriteLine("Subject : "+Subject);
            }
        }
        class HeadTeacher : Teacher
        {
            public string Department;
            public HeadTeacher(string name, string subject, string department) : base(name, subject)
            {
                Department = department;
            }
            public void DisplayHeadTeacherDetails()
            {
                DisplayTeacherDetails();
                Console.WriteLine("Department : " + Department);
            }
        }

        // print book details
        class LibraryItem
        {
            public string Title;
            public string Author;
            public LibraryItem(string title, string author)
            {
                Title = title;
                Author = author;
            }
            public void DisplayLibraryItem()
            {
                Console.WriteLine("Title : "+Title);
                Console.WriteLine("Author : "+Author);
            }
        }
        class Book : LibraryItem
        {
            public string ISBN;
            public int Page;
            public Book(string title, string author, string isbn, int page): base(title, author)
            {
                ISBN = isbn;
                Page = page;
            }
            public void DisplayBookDetails()
            {
                DisplayLibraryItem();
                Console.WriteLine("ISBN: " + ISBN);
                Console.WriteLine("Pages: " + Page);

            }
        }

        //.........................................Hierarchical Inheritance...................................

        //employee details
        class Employee
        {
            public int Id;
            public string Name;
            public double Salary;

            public Employee(int id, string name, double salary)
            {
                Id = id;
                Name = name;
                Salary = salary;
            }
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("Employee ID: " + Id);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Salary: " + Salary);
            }
        }
            class FullTimeEmployee : Employee
            {
                public string Benefits; 

                public FullTimeEmployee(int id, string name, double salary, string benefits): base(id, name, salary)
                {
                    Benefits = benefits;
                }
                public void DisplayFullTimeDetails()
                {
                    DisplayEmployeeDetails();
                    Console.WriteLine("Benefits: " + Benefits);
                }
        }
        class PartTimeEmployee : Employee
        {
            public double HourlyRate ;
            public PartTimeEmployee(int id, string name, double salary, double hourlyRate)
                : base(id, name, salary)
            {
                HourlyRate = hourlyRate;
            }
            public void DisplayPartTimeDetails()
            {
                DisplayEmployeeDetails();
                Console.WriteLine("Hourly Rate: " + HourlyRate);
            }
        }

        //
        class Device
        {
            public string Brand { get; set; }

            public Device(string brand)
            {
                Brand = brand;
            }

            public void DisplayDevice()
            {
                Console.WriteLine("Brand: " + Brand);
            }
        }
        class MobilePhone : Device
        {
            public string Model;
            public double Price;
            public MobilePhone(string brand, string model, double price): base(brand)  
            {
                Model = model;
                Price = price;
            }
            public void DisplayMobileDetails()
            {
                DisplayDevice();
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Price: " + Price);
            }
        }
        class Laptop : Device
        {
            public string Processor { get; set; }
            public int RAM { get; set; }
            public Laptop(string brand, string processor, int ram): base(brand)
            {
                Processor = processor;
                RAM = ram;
            }
            public void DisplayLaptopDetails()
            {
                DisplayDevice();
                Console.WriteLine("Processor: " + Processor);
                Console.WriteLine("RAM: " + RAM + " GB");
            }
        }

        //vehicle
        class Vehicle
        {
            public void Drive()
            {
                Console.WriteLine("Vehicle can driven.");
            }
        }
        class Car : Vehicle
        {
            public int NumberOfDoors;
            public Car(int doors)
            {
                NumberOfDoors = doors;
            }
            public void ShowCarDetails()
            {
                Console.WriteLine($"Car with {NumberOfDoors} doors.");
            }
        }
        class Bike : Vehicle
        {
            public bool HasGear ;

            public Bike(bool gear)
            {
                HasGear = gear;
            }

            public void ShowBikeDetails()
            {
                Console.WriteLine(HasGear ? "Bike has gears." : "Bike does not have gears.");
            }
        }





        static void Main()
        {
            //student Student = new student();
            //Student.Name = "Alisha";
            //Student.Age = 20;
            //Student.RollNo = 10;
            //Student.course = "btech";
            //Student.displayStudent();
            //Console.ReadLine();

            //SavingsAccount save = new SavingsAccount(10000, 3000, 3);
            //save.DisplaySavingsDetails();

            //HeadTeacher head = new HeadTeacher("Anna", "English", "cs");
            //head.DisplayHeadTeacherDetails();

            //Book myBook = new Book("Aadujeevitham", "Benyamin", "9788126415786", 380);
            //myBook.DisplayBookDetails();

            //FullTimeEmployee full = new FullTimeEmployee(2, "Alisha", 25000, "Health Insurance");
            //PartTimeEmployee part = new PartTimeEmployee(3, "Anna", 20000, 200);
            //full.DisplayFullTimeDetails();
            //part.DisplayPartTimeDetails();

            //MobilePhone phone = new MobilePhone("Samsung", "Galaxy S24", 79999);
            //Console.WriteLine("Mobile Phone Details:");
            //phone.DisplayMobileDetails();
            //Laptop laptop = new Laptop("Dell", "Intel i7", 16);
            //Console.WriteLine("Laptop Details:");
            //laptop.DisplayLaptopDetails();

            Car myCar = new Car(4);
            myCar.ShowCarDetails();
            myCar.Drive();
            Console.WriteLine();
            Bike myBike = new Bike(true);
            myBike.ShowBikeDetails();
            myBike.Drive();

















        }
    }
}
