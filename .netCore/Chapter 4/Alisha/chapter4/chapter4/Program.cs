namespace chapter4
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public int Marks { get; set; }
    }
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
    }
    public class BankTransaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } 
        public DateTime Date { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Activity1-Employee Dataset...........
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alisha", Department = "HR", Salary = 40000 },
                new Employee { Id = 2, Name = "Aneesha", Department = "HR", Salary = 55000 },
                new Employee { Id = 3, Name = "Cindra", Department = "Manger", Salary = 70000 },
                new Employee { Id = 4, Name = "Daisy", Department = "IT", Salary = 60000 },
                new Employee { Id = 5, Name = "Evan", Department = "IT", Salary = 52000 }
            };
            var highsalary = employees.Where(e => e.Salary > 50000);
            Console.WriteLine("High Earners (>50k):");
            foreach (var e in highsalary) Console.WriteLine($"{e.Name} - {e.Salary}");


            var employeeNames = employees.Select(e => e.Name);
            Console.WriteLine("\nEmployee Names:");
            foreach (var name in employeeNames) Console.WriteLine(name);


            var sortedBySalaryDesc = employees.OrderByDescending(e => e.Salary);
            Console.WriteLine("\nSorted by Salary Descending:");
            foreach (var e in sortedBySalaryDesc) Console.WriteLine($"{e.Name} - {e.Salary}");


            var sortedByDeptThenSalary = employees.OrderBy(e => e.Department).ThenBy(e => e.Salary);
            Console.WriteLine("\nSorted by Department then Salary:");
            foreach (var e in sortedByDeptThenSalary) Console.WriteLine($"{e.Department} - {e.Name} - {e.Salary}");


            var countPerDept = employees.GroupBy(e => e.Department).Select(g => new { Department = g.Key, Count = g.Count() });
            Console.WriteLine("\nCount per Department:");
            foreach (var group in countPerDept) Console.WriteLine($"{group.Department}: {group.Count}");


            double maxSalary = employees.Max(e => e.Salary);
            Console.WriteLine($"\nHighest Salary: {maxSalary}");


            bool allAbove20k = employees.All(e => e.Salary > 20000);
            Console.WriteLine($"All earn >20k? {allAbove20k}");


            var firstInIT = employees.FirstOrDefault(e => e.Department == "IT");
            Console.WriteLine("\nFirst Employee in IT:");
            Console.WriteLine(firstInIT != null ? $"{firstInIT.Name} - {firstInIT.Salary}" : "None found");



            var distinctDepartments = employees.Select(e => e.Department).Distinct();
            Console.WriteLine("\nDistinct Departments:");
            foreach (var dept in distinctDepartments) Console.WriteLine(dept);


            //Activity2- E-commerce Orders.................
            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerId = 1, CustomerName = "Alice" },
                new Customer { CustomerId = 2, CustomerName = "Bob" },
                new Customer { CustomerId = 3, CustomerName = "Charlie" }
            };
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 1, Amount = 5000, Date = DateTime.Now.AddDays(-2) },
                new Order { OrderId = 2, CustomerId = 2, Amount = 25000, Date = DateTime.Now.AddDays(-10) },
                new Order { OrderId = 3, CustomerId = 3, Amount = 1500, Date = DateTime.Now.AddDays(-1) },
                new Order { OrderId = 4, CustomerId = 1, Amount = 120000, Date = DateTime.Now.AddDays(-5) },
            };
            double totalSales = orders.Sum(o => o.Amount);
            Console.WriteLine($"Total Sales Amount: {totalSales}");


            DateTime sevenDaysAgo = DateTime.Now.AddDays(-7);
            var recentOrders = orders
                               .Where(o => o.Date >= sevenDaysAgo)
                               .Select(o => new { o.OrderId, o.Amount });
            Console.WriteLine("\nRecent Orders (Last 7 Days):");
            foreach (var o in recentOrders)
                Console.WriteLine($"OrderId: {o.OrderId}, Amount: {o.Amount}");


            bool anyBigOrder = orders.Any(o => o.Amount > 100000);
            Console.WriteLine($"\nAny Order > 1,00,000? {anyBigOrder}");

            
            double minAmount = orders.Min(o => o.Amount);
            var smallestOrder = orders.FirstOrDefault(o => o.Amount == minAmount);
            Console.WriteLine("\nOrder with Smallest Amount:");
            Console.WriteLine(smallestOrder != null
                ? $"OrderId: {smallestOrder.OrderId}, Amount: {smallestOrder.Amount}"
                : "No orders found");

           
            var orderDetails = orders.Join(customers,
                                           o => o.CustomerId,
                                           c => c.CustomerId,
                                           (o, c) => new { c.CustomerName, o.Amount });
            Console.WriteLine("\nOrders with Customer Names:");
            foreach (var item in orderDetails)
                Console.WriteLine($"{item.CustomerName} - Amount: {item.Amount}");


            
            var customerOrders = customers.GroupJoin(
                orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, oGroup) => new
                {
                    c.CustomerName,
                    Orders = oGroup
                });
            Console.WriteLine("\nCustomers with their Orders:");
            foreach (var group in customerOrders)
            {
                Console.WriteLine($"{group.CustomerName}:");
                foreach (var o in group.Orders)
                    Console.WriteLine($"   OrderId: {o.OrderId}, Amount: {o.Amount}");
                if (!group.Orders.Any())
                    Console.WriteLine("   No orders");
            }

            //activity3  Student Records
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Alisha", Grade = "Science", Marks = 85 },
                new Student { Id = 2, Name = "Boby", Grade = "Math", Marks = 75 },
                new Student { Id = 3, Name = "Anna", Grade = "Science", Marks = 92 },
                new Student { Id = 4, Name = "Minna", Grade = "Math", Marks = 35 },
            };
            var top3 = students.OrderByDescending(s => s.Marks).Take(3);
            Console.WriteLine("Top 3 Students by Marks:");
            foreach (var s in top3)
                Console.WriteLine($"{s.Name} - {s.Marks}");

            

            var avgPerGrade = students
                              .GroupBy(s => s.Grade)
                              .Select(g => new { Grade = g.Key, AvgMarks = g.Average(s => s.Marks) });
            Console.WriteLine("\nAverage Marks per Grade:");
            foreach (var g in avgPerGrade)
                Console.WriteLine($"{g.Grade}: {g.AvgMarks:F2}");



            bool allPassed = students.All(s => s.Marks > 40);
            Console.WriteLine($"\nAll Students Passed? {allPassed}");

            

            var topStudent = students.OrderByDescending(s => s.Marks).First();
            Console.WriteLine("\nStudent with Highest Marks:");
            Console.WriteLine($"{topStudent.Name} - {topStudent.Marks}");
            

            var scienceStudents = students.Where(s => s.Grade == "Science").Select(s => s.Name);
            var mathStudents = students.Where(s => s.Grade == "Math").Select(s => s.Name);
            var scienceNotMath = scienceStudents.Except(mathStudents);
            Console.WriteLine("\nStudents in Science but not in Math:");
            foreach (var name in scienceNotMath)
                Console.WriteLine(name);


            //activity4 Library Books
            List<Book> library1 = new List<Book>
            {
                new Book { BookId = 1, Title = "Wings of Fire", Author = "APJ Abdul Kalam", Category = "Science", Price = 450, IsAvailable = true },
                new Book { BookId = 2, Title = "Cosmos", Author = "Carl Sagan", Category = "Science", Price = 500, IsAvailable = false },
                new Book { BookId = 3, Title = "C# in Depth", Author = "Jon Skeet", Category = "Programming", Price = 650, IsAvailable = true },
                new Book { BookId = 4, Title = "Clean Code", Author = "Robert C. Martin", Category = "Programming", Price = 550, IsAvailable = true },
                new Book { BookId = 5, Title = "Ignited Minds", Author = "APJ Abdul Kalam", Category = "Science", Price = 400, IsAvailable = true }
            };
            List<Book> library2 = new List<Book>
            {
                new Book { BookId = 5, Title = "Ignited Minds", Author = "APJ Abdul Kalam", Category = "Science", Price = 400, IsAvailable = true },
                new Book { BookId = 6, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Category = "Programming", Price = 600, IsAvailable = true },
                new Book { BookId = 1, Title = "Wings of Fire", Author = "APJ Abdul Kalam", Category = "Science", Price = 450, IsAvailable = true }
            };
            var availableScience = library1
                               .Where(b => b.IsAvailable && b.Category == "Science");
            Console.WriteLine("Available Science Books:");
            foreach (var b in availableScience)
                Console.WriteLine($"{b.Title} by {b.Author}");


            var titlesAndPrices = library1.Select(b => new { b.Title, b.Price });
            Console.WriteLine("\nTitles and Prices:");
            foreach (var t in titlesAndPrices)
                Console.WriteLine($"{t.Title} - ₹{t.Price}");


            double avgPrice = library1.Average(b => b.Price);
            Console.WriteLine($"\nAverage Book Price: ₹{avgPrice:F2}");

            var countPerCategory = library1
                              .GroupBy(b => b.Category)
                              .Select(g => new { Category = g.Key, Count = g.Count() });
            Console.WriteLine("\nBooks per Category:");
            foreach (var c in countPerCategory)
                Console.WriteLine($"{c.Category}: {c.Count}");

            bool hasKalamBook = library1.Any(b => b.Author == "APJ Abdul Kalam");
            Console.WriteLine($"\nHas any book by APJ Abdul Kalam? {hasKalamBook}");

            var commonBooks = library1.Select(b => b.Title)
                                 .Intersect(library2.Select(b => b.Title));
            Console.WriteLine("\nCommon Books between Library1 and Library2:");
            foreach (var title in commonBooks)
                Console.WriteLine(title);

            //activity 7
            List<BankTransaction> transactions = new List<BankTransaction>
            {
                new BankTransaction { TransactionId = 1, AccountId = 101, Amount = 12000, Type = "Debit", Date = DateTime.Now },
                new BankTransaction { TransactionId = 2, AccountId = 101, Amount = 8000,  Type = "Credit", Date = DateTime.Now },
                new BankTransaction { TransactionId = 3, AccountId = 102, Amount = 15000, Type = "Debit", Date = DateTime.Now },
                new BankTransaction { TransactionId = 4, AccountId = 103, Amount = 5000,  Type = "Credit", Date = DateTime.Now },
                new BankTransaction { TransactionId = 5, AccountId = 101, Amount = 2000,  Type = "Debit", Date = DateTime.Now },
                new BankTransaction { TransactionId = 6, AccountId = 103, Amount = 7000,  Type = "Credit", Date = DateTime.Now },
            };
            var highDebitTransactions = transactions
    .Where(t => t.Type == "Debit" && t.Amount > 10000);

            foreach (var t in highDebitTransactions)
                Console.WriteLine($"ID:{t.TransactionId}, Acc:{t.AccountId}, Amount:{t.Amount}");

            var totalCredit = transactions
    .Where(t => t.Type == "Credit")
    .Sum(t => t.Amount);

            Console.WriteLine($"Total Credit Amount: {totalCredit}");


            var totalsPerAccount = transactions
    .GroupBy(t => t.AccountId)
    .Select(g => new
    {
        AccountId = g.Key,
        TotalDebit = g.Where(t => t.Type == "Debit").Sum(t => t.Amount),
        TotalCredit = g.Where(t => t.Type == "Credit").Sum(t => t.Amount)
    });

            foreach (var acc in totalsPerAccount)
                Console.WriteLine($"Account:{acc.AccountId}, Debit:{acc.TotalDebit}, Credit:{acc.TotalCredit}");

            bool hasManyTransactions = transactions
    .GroupBy(t => t.AccountId)
    .Any(g => g.Count() > 5);

            Console.WriteLine($"Any account with >5 transactions? {hasManyTransactions}");

            var transactionDictionary = transactions
    .ToDictionary(t => t.TransactionId);

            foreach (var kvp in transactionDictionary)
                Console.WriteLine($"Key:{kvp.Key}, Account:{kvp.Value.AccountId}, Amount:{kvp.Value.Amount}");


            //activity8
            var squares = Enumerable.Range(1, 10)
                               .Select(n => new { Number = n, Square = n * n });

            foreach (var item in squares)
                Console.WriteLine($"{item.Number}² = {item.Square}");

            Console.WriteLine("\nRepeating 'Hello' 5 times:");
            var greetings = Enumerable.Repeat("Hello", 5);

            foreach (var word in greetings)
                Console.WriteLine(word);

            Console.WriteLine("\nEmpty integer sequence:");
            var emptyNumbers = Enumerable.Empty<int>();

            Console.WriteLine($"Count: {emptyNumbers.Count()}"); 
        }
    }












}
    }
}
