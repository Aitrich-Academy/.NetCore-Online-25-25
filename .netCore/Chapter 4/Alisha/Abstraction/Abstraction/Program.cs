namespace Abstraction
{
    //.........................................abstraction activity........................................................
    //car and bike
    abstract class Vehicle
    {
        public abstract void Start();
        public void Fuel()
        {
            Console.WriteLine("Fuel fill");
        }
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car started");
        }
    }
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike started");
        }
    }

    //........................................ Interface Activities..................................................

    //Payment Systemin
    interface IPayment
    {
        void Pay(double amount);
        void Refund(double amount);
    }
    class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }

        public void Refund(double amount)
        {
            Console.WriteLine($"Refunded {amount} to Credit Card.");
        }
    }
    class UPIPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using UPI.");
        }

        public void Refund(double amount)
        {
            Console.WriteLine($"Refunded {amount} to UPI.");
        }
    }

    // ........................Multiple Inheritance (via Interfaces)...................................

    //Student Information
    interface IPerson
    {
        string GetName();
    }
    interface IStudent
    {
        string GetCourse();
    }
    class CollegeStudent : IPerson, IStudent
    {
        private string name;
        private string course;

        public CollegeStudent(string name, string course)
        {
            this.name = name;
            this.course = course;
        }
        public string GetName()
        {
            return name;
        }
        public string GetCourse()
        {
            return course;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {GetName()}, Course: {GetCourse()}");
        }
    }

    internal class Program

    {
        static void Main(string[] args)
        {
            //Vehicle car = new Car();
            //car.Start();
            //car.Fuel();
            //Console.WriteLine();
            //Vehicle bike = new Bike();
            //bike.Start();
            //bike.Fuel();


            //IPayment payment1 = new CreditCardPayment();
            //payment1.Pay(500);
            //payment1.Refund(200);
            //Console.WriteLine();
            //IPayment payment2 = new UPIPayment();
            //payment2.Pay(300);
            //payment2.Refund(100);


            CollegeStudent student1 = new CollegeStudent("Alisha", "Computer Science");
            student1.DisplayDetails();
            IPerson p = student1;
            IStudent s = student1;
            Console.WriteLine("Using IPerson reference: " + p.GetName());
            Console.WriteLine("Using IStudent reference: " + s.GetCourse());


        }
    }
}
