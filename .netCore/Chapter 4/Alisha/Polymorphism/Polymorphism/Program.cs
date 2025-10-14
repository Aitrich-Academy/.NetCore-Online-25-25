namespace Polymorphism
{
    internal class Program
    {
        //Calculator Class
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public double Add(double a, double b)
            {
                return a + b;
            }
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
        }

        //Area of Shapes
        class AreaCalculator
        {
            public double Area(double radius)
            {
                return Math.PI * radius * radius;
            }
            public double Area(double length,double width)
            {
                return length * width;
            }
            public double Area(double b, double h,bool isTriangle )
            {
                return 0.5 * b * h;
            }
        }


        //Greeting Method
        class Greeter
        {
            public void SayHello()
            {
                Console.WriteLine("Hello World!");
            }
            public void SayHello(string name)
            {
                Console.WriteLine("Hello, " + name);
            }
            public void SayHello(string firstName, string lastName)
            {
                Console.WriteLine("Hello, " + firstName + " " + lastName);
            }
        }

        //Bank transaction
        class Bank
        {
            public void Deposit(int amount)
            {
                Console.WriteLine($"Deposited Rs.{amount}");
            }
            public void Deposit(double amount)
            {
                Console.WriteLine($"Deposited Rs.{amount}");
            }
            public void Deposit(int amount, string accountNumber)
            {
                Console.WriteLine($"Deposited Rs.{amount} into Account: {accountNumber}");
            }
        }

        // ........................Method Overriding (Run-time Polymorphism)......................................................

        //animal sound

        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }
        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog barks: Woof Woof!");
            }
        }
        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Cat meows: Meow Meow!");
            }
        }

        static void Main(string[] args)
        {
            //Calculator calc = new Calculator();
            //Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
            //Console.WriteLine("Add(double, double): " + calc.Add(4.5, 3.2));
            //Console.WriteLine("Add(int, int, int): " + calc.Add(2, 4, 6));


            //AreaCalculator calc = new AreaCalculator();
            //Console.WriteLine("Area of Circle : " + calc.Area(5));
            //Console.WriteLine("Area of Rectangle : " + calc.Area(4, 6));
            //Console.WriteLine("Area of Triangle : " + calc.Area(10, 8, true));


            //Greeter greet = new Greeter();
            //greet.SayHello();   
            //greet.SayHello("Alisha"); 
            //greet.SayHello("Alisha", "Varghese");


            Bank bank = new Bank();
            bank.Deposit(5000);                 
            bank.Deposit(1000.50);      
            bank.Deposit(25000, "ACC123456789");





        }
    }
}
