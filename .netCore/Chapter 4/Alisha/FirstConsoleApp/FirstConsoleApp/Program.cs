namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.WriteLine("Hello,enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("your name is " + name+ " and your age is "+age);
            //Console.WriteLine("your age is " + age);

        }
    }
}
