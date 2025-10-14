using System.Collections;

namespace collections
{
    internal class Program
    {
        static void Main()
        {
            //ArrayList
            //ArrayList joblist = new ArrayList();
            //joblist.Add("Dotnet Developer");
            //joblist.Add("Java Developer");
            //joblist.Add("Angular Developer");
            //Console.WriteLine("The jobs in the list are : ");
            //foreach (var item in joblist)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(joblist.Count);
            //Console.WriteLine(joblist.Contains("Dotnet Developer"));
            //joblist.Remove("Dotnet Developer");

            //foreach (var item in joblist)
            //{
            //    Console.WriteLine(item);
            //}
            //joblist.Insert(0, "Dotnet Developer");

            //foreach (var item in joblist)
            //{
            //    Console.WriteLine(item);
            //}
            //joblist.RemoveAt(2);

            //Console.WriteLine("Contains 'Dotnet Developer'? " + joblist.Contains("Dotnet Developer"));

            //Console.WriteLine("Index of 'Java Developer': " + joblist.IndexOf("Java Developer"));

            //Console.WriteLine("\nTotal jobs: " + joblist.Count);

            //joblist.Sort();
            //Console.WriteLine("\nAfter sorting:");
            //foreach (var item in joblist)
            //{
            //    Console.WriteLine(item);
            //}



            //Hashtable
            //Hashtable Jobs = new Hashtable();
            //Jobs.Add("Dotnet Developer", 1);
            //Jobs.Add("Java Developer", 2);
            //Jobs.Add("Angular Developer", 3);
            //Console.WriteLine("The jobs in the list are : ");
            //foreach (DictionaryEntry entry in Jobs)
            //{
            //    Console.WriteLine($"{entry.Key}:{entry.Value}");
            //}

            //Jobs.Remove("Angular Developer");
            //Console.WriteLine("\nAfter removing 'Angular Developer':");
            //foreach (DictionaryEntry entry in Jobs)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            //}

            //Console.WriteLine("Contains 'Dotnet Developer'? " + Jobs.Contains("Dotnet Developer"));

            //Console.WriteLine("ContainsKey 'Java Developer'? " + Jobs.ContainsKey("Java Developer"));

            //Console.WriteLine("ContainsValue 3? " + Jobs.ContainsValue(3));
            //Console.WriteLine("\nTotal number of jobs: " + Jobs.Count);





            //QUEUE
            //Queue jobs = new Queue();
            //jobs.Enqueue("Dotnet Developer");
            //jobs.Enqueue("Java Developer");
            //jobs.Enqueue("Angular Developer");
            //Console.WriteLine("The jobs in the queue are:");
            //foreach (var job in jobs)
            //{
            //    Console.WriteLine(job);
            //}

            //Console.WriteLine("Removed: " + jobs.Dequeue());

            //Console.WriteLine("Peek (first job): " + jobs.Peek());

            //Console.WriteLine("\nTotal jobs in queue: " + jobs.Count);




            //STACK
            //Stack jobs = new Stack();
            //jobs.Push("Dotnet Developer");
            //jobs.Push("Java Developer");
            //jobs.Push("Angular Developer");
            //Console.WriteLine("The jobs in the Stack are:");
            //foreach (var job in jobs)
            //{
            //    Console.WriteLine(job);
            //}
            //Console.WriteLine("Removed: " + jobs.Pop());
            //Console.WriteLine("Peek (top job): " + jobs.Peek());
            //Console.WriteLine("\nTotal jobs in stack: " + jobs.Count);
            //Console.WriteLine("Contains 'Java Developer'? " + jobs.Contains("Java Developer"));




            //SORTED LIST
            SortedList jobs = new SortedList();
            jobs.Add("dotnet developer", 1);
            jobs.Add("java developer", 2);
            jobs.Add("angular developer", 3);

            Console.WriteLine("The jobs available are:");
            foreach (var key in jobs.Keys)
            {
                Console.WriteLine($"{key} : {jobs[key]}");
            }
            jobs.Remove("dotnet developer");
            Console.WriteLine("\nAfter removing 'dotnet developer':");
            foreach (var key in jobs.Keys)
            {
                Console.WriteLine($"{key} : {jobs[key]}");
            }
            Console.WriteLine("ContainsKey 'java developer'? " + jobs.ContainsKey("java developer"));
            Console.WriteLine("IndexOfKey 'angular developer': " + jobs.IndexOfKey("angular developer"));
            Console.WriteLine("IndexOfValue 2: " + jobs.IndexOfValue(2));
            Console.WriteLine("\nTotal jobs: " + jobs.Count);











        }
    }
}
