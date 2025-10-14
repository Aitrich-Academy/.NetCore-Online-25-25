namespace LINQ
{
    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public string? Department { get; set; }
    //    public int Salary { get; set; }
    //}
    class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }


        public product(int id, string name, decimal cost)
        {
            Id = id;
            Name = name;
            Cost = cost;
        }
    }
    class item
    {
        public int ProductId { get; set; }
        public int Qty {  get; set; }
        public decimal Price {  get; set; }
        public item(int productId, int qty, decimal price)
        {
            ProductId = productId;
            Qty = qty;
            Price = price;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var scores = new List<int> { 1, 1, 5, 2, 3, 8, 7, 9 };
            //var sortedScores = scores.OrderBy(n => n);

            //foreach (var score in sortedScores)
            //{
            //    Console.Write($"{score} ");
            //}

            //var sortedNumbers = scores.OrderByDescending(number => number);

            //foreach (var number in sortedNumbers)
            //{
            //    Console.WriteLine($"{number} ");
            //}

            //var employees = new List<Employee>()
            //{
            //new Employee { Id=1, Name = "John", Department = "HR", Salary = 50000 },
            //new Employee { Id=2, Name = "Jane", Department = "IT", Salary = 60000 },
            //new Employee { Id=3, Name = "Bob", Department = "HR", Salary = 45000 }
            //};
            //var results = employees.OrderBy(e => e.Department).ThenBy(e => e.Salary);
            //foreach (var e in results)
            //{
            //    Console.WriteLine($"{e.Department} - {e.Name} - {e.Salary:C}");
            //}

            //int[] marks = { 2, 5, 7, 3, 8, 9 };
            //var filteredScores = scores.Where(n => n >= 5);
            //foreach (var score in filteredScores)
            //{
            //    Console.WriteLine(score);
            //}


            //int firstEvenNumber = marks.First(n => n % 2 == 0);
            //Console.WriteLine($"The first even number is: {firstEvenNumber}");

            //int firstEvenNum = marks.FirstOrDefault(n => n % 2 == 0);
            //Console.WriteLine($"The first even number is: {firstEvenNumber}");


            //int lastEvenNumber = marks.Last(n => n % 2 == 0);
            //Console.WriteLine($"The last even number is: {lastEvenNumber}");


            //int lastEvenNum = marks.LastOrDefault(n => n % 2 == 0);
            //Console.WriteLine($"The last even number is: {lastEvenNumber}");


            //var employee = employees.Single(e => e.Id == 1);
            //Console.WriteLine($"{employee.Id} - {employee.Name}");


            //var uniqueScores = scores.Distinct();
            //foreach (var score in uniqueScores)
            //{
            //    Console.Write($"{score} ");
            //}


           

            //int[] sco = { 1, 2, 3, 4, 5 };
            //var result = sco.Skip(2);
            //foreach (var total in result)
            //{
            //   Console.WriteLine(result);
            //}


            //var numbers = new List<int> { 1, 2, 3, 6, 7, 8, 4, 9 };
            //var re = numbers.SkipWhile(x => x <= 5);
            //foreach (var number in re)
            //{
            //   Console.WriteLine(number);
            //}


            //var res = numbers.SkipLast(3);
            //foreach (var number in res)
            //{
            //    Console.WriteLine(number);
            //}


            //var num = new List<int>(Enumerable.Range(1, 25));
            //var chunks = num.Chunk(10);
            //foreach (var chunk in chunks)
            //{
            //    foreach (var item in chunk)
            //    {
            //       Console.Write($"{item}, ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] numb = { 5, 7, 2, 1, 0 };
            //bool hasNumber = numb.Any();
            //if (hasNumber)
            //{
            //    Console.WriteLine("The numbers has element(s).");
            //}


            //int[] no = { 2, 4, 6, 8 };
            //bool allEvenNumbers = no.All(n => n % 2 == 0 ? true : false);
            //if (allEvenNumbers)
            //{
            //    Console.WriteLine("All numbers are even.");
            //}


            //int[] nmb = { 1, 2, 3, 4, 5 };
            //bool containsThree = nmb.Contains(3);
            //bool containsTen = nmb.Contains(10);
            //Console.WriteLine(containsThree);
            //Console.WriteLine(containsTen);




            //inner join
            var products = new List<product>()
            {
                new(id:1, name:"A",cost:10),
                new(id:2, name:"B",cost:20),
                new(id:3, name:"C",cost:30)
            };
            var items = new List<item>()
            {
                new (productId:8, qty: 2, price: 12),
                new (productId:2, qty: 2, price: 25),
                new (productId:3, qty: 4, price: 35)
            };
            var Result = items.Join(
                products,
                item => item.ProductId,
                product =>product.Id,
                (item,product) => new
                {
                    product.Name,
                    product.Cost,
                    item.Price,
                    item.Qty,
                    Margin = (item.Price - product.Cost)*item.Qty      
                }
                );
            foreach (var Results in Result)
            {
                Console.WriteLine(Results);
            }




        }
    }
}






           

        




        
