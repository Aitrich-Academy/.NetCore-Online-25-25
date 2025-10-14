
using System.Collections;
using System.Collections.Generic;

namespace collectionActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Non-Generic Collections

            ArrayList list = new ArrayList();
            list.Add(100);             
            list.Add("Hello");         
            list.Add(99.9);            
            list.Add("World");       
            list.Add(500);
            list.Insert(2, "Inserted Value");
            list.Remove("Hello");
            Console.WriteLine("ArrayList elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Hashtable countries = new Hashtable();
            countries.Add("IN", "India");
            countries.Add("US", "United States");
            countries.Add("UK", "United Kingdom");
            countries.Add("AU", "Australia");
            countries.Add("CA", "Canada");
            Console.WriteLine("Country Codes and Names:");
            foreach (DictionaryEntry entry in countries)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }


            ArrayList number = new ArrayList();
            number.Add(45);
            number.Add(10);
            number.Add(78);
            number.Add(23);
            number.Add(56);
            Console.WriteLine("Original Numbers:");
            foreach (var num in number)
            {
                Console.Write(num + " ");
            }
            number.Sort();
            Console.WriteLine("\n\nSorted Numbers:");
            foreach (var num in number)
            {
                Console.Write(num + " ");
            }
            int min = (int)number[0];                 
            int max = (int)number[number.Count - 1];
            Console.WriteLine($"\n\nMinimum Value: {min}");
            Console.WriteLine($"Maximum Value: {max}");




            //Generic Collections
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("Grapes");
            fruits.Sort();
            if (fruits.Contains("Apple"))
            {
                Console.WriteLine("\nApple found");
                fruits.Remove("Apple");
            }
            else
            {
                Console.WriteLine("\nApple not found");
            }
            Console.WriteLine("\nFruits after removal:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }



            Stack<int> numbers = new Stack<int>();
            for (int i = 1; i <= 5; i++)
            {
                numbers.Push(i);
                Console.WriteLine(i);
            }
            Console.WriteLine("\nPopping all elements (LIFO order):");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }



            Queue<string> tickets = new Queue<string>();
            tickets.Enqueue("Ticket 1");
            tickets.Enqueue("Ticket 2");
            tickets.Enqueue("Ticket 3");
            tickets.Enqueue("Ticket 4");
            tickets.Enqueue("Ticket 5");
            Console.WriteLine("All Tickets in Queue:");
            foreach (var t in tickets)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("Dequeued: " + tickets.Dequeue());
            Console.WriteLine("Dequeued: " + tickets.Dequeue());
            Console.WriteLine("\nRemaining Tickets in Queue:");
            foreach (var t in tickets)
            {
                Console.WriteLine(t);
            }



            //Comparison / Advanced Activities
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add("Hello");
            Console.WriteLine("ArrayList elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);
            Console.WriteLine("List<int> elements:");
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }


            Hashtable studentTable = new Hashtable();
            studentTable.Add(1, "Alisha");
            studentTable.Add(2, "Aneesha");
            foreach (DictionaryEntry entry in studentTable)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
            Dictionary<int, string> studentDict = new Dictionary<int, string>();
            studentDict.Add(1, "Alisha");
            studentDict.Add(2, "Aneehsa");
            foreach (var student in studentDict)
            {
                Console.WriteLine($"{student.Key} : {student.Value}");
            }


            SortedList<int, string> students = new SortedList<int, string>();
            students.Add(5, "Alisha");
            students.Add(2, "Anu");
            students.Add(1, "Manu");
            students.Add(4, "Dani");
            students.Add(3, "Rijo");
          
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}   {student.Value}");
            }








        }
    }
}
