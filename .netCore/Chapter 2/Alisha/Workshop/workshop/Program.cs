namespace workshop
{
    internal class Program
    {
        struct admin
        {
            public string name;
            public string username;
            public string email;
            public long phone;
        }

        static void Main(string[] args)
        {
            string ch;
            admin[] profile = new admin[1];
            Console.WriteLine("..............................WELCOME TO ADMIN PANEL..................................");
            do
            {
                Console.WriteLine("A---Register as Admin");
                Console.WriteLine("D---Display admins details");
                Console.WriteLine("select an option A or D");
                string command=Console.ReadLine();
                switch (command)
                {
                    case "A":
                        {
                            Console.WriteLine(".............................Register as Admin...........................");
                            Console.WriteLine("Enter Name : ");
                            profile[0].name = Console.ReadLine();
                            Console.WriteLine("Enter Username : ");
                            profile[0].username = Console.ReadLine();
                            Console.WriteLine("Enter Email : ");
                            profile[0].email = Console.ReadLine();
                            Console.WriteLine("Enter Phone number : ");
                            profile[0].phone = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case "D":
                        {
                            Console.WriteLine("..............................Admins Details...............................");
                            Console.WriteLine("Name: " + profile[0].name);
                            Console.WriteLine("Username: " + profile[0].username);
                            Console.WriteLine("Email: " + profile[0].email);
                            Console.WriteLine("Phone: " + profile[0].phone);
                            break;
                        }
                }
                        Console.WriteLine("Do you want to continue? (y/n): ");
                        ch = Console.ReadLine();
            }
            while (ch == "y");
        
           






            
        }
    }
}
