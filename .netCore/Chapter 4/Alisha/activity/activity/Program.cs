using System;
using System.Data;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Transactions;

namespace activity
{
    class Program
    {
        enum EmployeeRole
        {
            manager,
            teamlead,
            developer,
            tester
        }
        enum PizzaSize
        {
            Small = 100,
            Medium = 150,
            Large = 200
        }
        enum TrafficSignal
        {
            Red,
            Yellow,
            Green
        }
        enum Grade
        {
            Fail = 0,
            Pass = 1,
            Distinction = 2
        }
        struct Student
        {
            public int id;
            public string name;
            public float mark;
        }
        struct employee
        {
            public int empId;
            public string empName;
            public double salary;
        }
        static void Main(string[] args)
        {

            //    string name = "Alisha";
            //    int age = 20;
            //    float height = 5;

            //    Console.WriteLine("Name: " + name);
            //    Console.WriteLine("Age: " + age);
            //    Console.WriteLine("Height: " + height);
            //    Console.ReadLine();

            ////activity2
            //var Name = "Leena";
            //var Age = 30;
            //var price = 100;
            //var isAvailable = false;

            //Console.WriteLine("name is " + Name.GetType());
            //Console.WriteLine("age is " + Age.GetType());
            //Console.WriteLine("price is " + price.GetType());
            //Console.WriteLine("isAvailable iS " + isAvailable.GetType());

            ////activity3

            ////activity4
            //Console.Write("Enter your name: ");
            //string name1 = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter your salary: ");
            //int salary = int.Parse(Console.ReadLine());
            //Console.WriteLine("Name is " + name1);
            //Console.WriteLine("Age is " + age1);
            //Console.WriteLine("Salary is " + salary);

            ////activity5

            ////activity6

            ////activity7

            ////activity8
            //int firstNumber = 10;
            //string fullName = "Alice";
            //double totalPrice = 100.5;
            //bool isValid = true;

            //Console.WriteLine(firstNumber);
            //Console.WriteLine(fullName);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(isValid);
            //Console.ReadLine();

            ////activity9
            //string item = "apple";
            //int quantity = 5;
            //float pricePerItem= 50;
            //float total = quantity * pricePerItem;
            //Console.WriteLine("Item Name: " + item);
            //Console.WriteLine("Quantity: " + quantity);
            //Console.WriteLine("Price per Item: " + pricePerItem);
            //Console.WriteLine("Total Price: " + total);
            //Console.ReadLine();

            ////activity10
            //byte number = 255;
            //number++;
            //Console.WriteLine(number);

            //...................activity for if.................
            //int number = 4;
            //if (number % 2 == 0) { 
            //    Console.WriteLine(number + " is even");
            //}

            //int age = 17;
            //if (age >= 18)
            //{
            //    Console.WriteLine("eligible for voting");
            //}
            //else
            //{
            //    Console.WriteLine("not eligible for voting");
            //}

            //...............................calculating grade..............................
            //Console.WriteLine("enter your mark : ");
            //int mark = Convert.ToInt32( Console.ReadLine());
            //if (mark > 90)
            //{
            //    Console.WriteLine("A grade");
            //}
            //else if(mark >= 80 & mark <= 89){
            //    Console.WriteLine("B grade");
            //}
            //else if (mark >= 70 & mark <= 79)
            //{
            //    Console.WriteLine("C grade");
            //}
            //else if (mark >= 60 & mark <= 69)
            //{
            //    Console.WriteLine("D grade");
            //}
            //else if (mark < 60)
            //{
            //    Console.WriteLine("fail");
            //}

            //..........................traffic light...........................
            //Console.WriteLine("light : ");
            //string color = Console.ReadLine();
            //switch (color)
            //{
            //    case "red":
            //        Console.WriteLine("stop");
            //        break;
            //    case "green":
            //        Console.WriteLine("go");
            //        break;
            //    case "yellow":
            //        Console.WriteLine("slow");
            //        break;
            //}

            //.......................Check Character Type..................
            //Console.WriteLine("Enter a single character : ");
            //char ch = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //if (ch >= 'A' && ch <= 'Z')
            //{
            //    Console.WriteLine("uppercase");
            //}
            // else if (ch >= 'a' && ch <= 'z')
            //{
            //    Console.WriteLine("lowercase");
            //}
            //else if (ch >= '0' && ch <= '9')
            //{
            //    Console.WriteLine("digit");
            //}
            //else
            //{
            //    Console.WriteLine("special character");
            //}

            //..........................Discount Checker...............
            //Console.WriteLine("Enter the price: ");
            //int price = Convert.ToInt32(Console.ReadLine());
            //if (price == 10000)
            //{
            //    Console.WriteLine("20% Discount");
            //}
            //else if (price >= 5001 && price < 10000)
            //{
            //    Console.WriteLine("10% Discount");
            //}
            //else if (price <= 5000)
            //{
            //    Console.WriteLine("No Discount");
            //}

            //Console.WriteLine("Enter the Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age > 0 && age <= 12)
            //{
            //    Console.WriteLine("Child");
            //}
            //else if (age >= 13 && age <= 19)
            //{
            //    Console.WriteLine("Teenager");
            //}
            //else if (age >=20 && age <= 59)
            //{
            //    Console.WriteLine("Adult");
            //}
            //else if (age >=60)
            //{
            //    Console.WriteLine("Senior Citizen");
            //}

            //.....................Day Type Checker(switch)............................

            //Console.Write("Enter a day: ");
            //string day = Console.ReadLine();
            //switch (day)
            //{
            //    case "monday":
            //    case "tuesday":
            //    case "wednesday":
            //    case "thursday":
            //    case "friday":
            //        Console.WriteLine("Weekday.");
            //        break;

            //    case "saturday":
            //    case "sunday":
            //        Console.WriteLine("Weekend.");
            //        break;
            //}

            //............................guess the number...........................

            //int number = 7;

            //Console.Write("Guess the number: ");
            //int guess = Convert.ToInt32(Console.ReadLine());

            //if (guess == number)
            //{
            //    Console.WriteLine("Correct!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong guess");
            //

            //....................................ATM Withdrawal.............................
            //Console.Write("Enter your current balance: ");
            //double balance = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter withdrawal amount: ");
            //double withdrawal = Convert.ToDouble(Console.ReadLine());

            //if (withdrawal <= balance)
            //{
            //    Console.WriteLine("Withdrawal is possible");
            //}
            //else
            //{
            //    Console.WriteLine("Insufficient funds.");
            //}

            //.................................Bmi checker...................................

            //Console.Write("Enter weight: ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter height: ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double bmi = weight / (height * height);
            //Console.WriteLine("Your BMI is: " + bmi);
            //if (bmi < 18.5)
            //{
            //    Console.WriteLine("Underweight");
            //}
            //else if (bmi >= 18.5 && bmi <= 24.9)
            //{
            //    Console.WriteLine("weight");
            //}
            //else if (bmi >= 25 && bmi <= 29.9)
            //{
            //    Console.WriteLine("Overweight");
            //}
            //else if (bmi >= 30)
            //{
            //    Console.WriteLine("Obese");
            //}

            //................................Loop activity........................................................
            //..................for loop......................
            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(num * i);
            //}

            //..........even numbers...........
            //Console.WriteLine();

            //            for (int i = 1; i <= 100; i++)
            //            {
            //                if (i % 2 == 0)
            //                {
            //                    Console.WriteLine(i);
            //                }
            //            }

            //..............sum of n numbers..........
            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("sum of  1 to " + num + " = " + sum);



            //...................................while loop..................................
            //.......password...........
            //string password = "";
            //while (password != "admin123")
            //{
            //    Console.WriteLine("enter a password : ");
            //    password = Console.ReadLine();
            //    if (password == "admin123")
            //    {
            //        Console.WriteLine("correct password");
            //    }
            //    else
            //    {
            //        Console.WriteLine("incorrect password");
            //    }
            //}
            //.......................count.......................
            //int num = 223342;
            //int count = 0;
            //while (num > 0)
            //{
            //    if (num % 10 == 4)
            //    {
            //        count++;
            //    }
            //    num= num / 10;
            //}
            //Console.WriteLine("count : "+count);

            //................reverse a number..............

            //int nums = 1234;
            //int rev = 0;
            //while(nums != 0)
            //{
            //    int number = nums % 10;
            //    rev=rev*10+number;
            //    nums = nums / 10;
            //}
            //Console.WriteLine(rev);

            //.........................atm withdraw................

            //int balance = 5000;
            //while (balance>0)
            //{
            //    Console.WriteLine("enter a amount : ");
            //    int amount =Convert.ToInt32 (Console.ReadLine());
            //    if (amount <balance)
            //    {
            //        balance =balance - amount;
            //        Console.WriteLine("insuffient balance");
            //    }
            //}

            //..................................for each..................................................................
            //display array
            //int[] array = {1, 2, 3, 4, 5 };

            //Console.WriteLine("Elements in array");

            //foreach (int num in array)
            //{
            //    Console.WriteLine(num);
            //}

            //.........................................Single dimension..............................................
            //...........Store and Display Student Mark.............

            //int[] marks = new int[5];
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.Write($"Enter mark for student {i + 1}: ");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("\nMarks of 5 students:");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Student {i + 1}: {marks[i]}");
            //}

            //................Matrix Multiplication(two dimensional)................

            //int[,] matrix1 = new int[2, 2];
            //int[,] matrix2 = new int[2, 2];
            //int[,] result= new  int[2, 2];

            //Console.WriteLine("\nenter elements of first matrix:");
            //for(int i = 0; i < 2; i++)
            //{
            //    for(int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"enter elements[{i},{j}]:");
            //        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\nmatrix[i,j]");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(matrix1[i,j]+" ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //................................Two dimensional array.........................................
            //....................Student Marks Report......................

            //int[,] mark = new int[3, 4];
            //int[] total = new int[3];
            //double[] average = new double[3];

            //mark[0, 0] = 80; mark[0, 1] = 70; mark[0, 2] = 88; mark[0, 3] = 98;
            //mark[1, 0] = 88; mark[1, 1] = 76; mark[1, 2] = 81; mark[1, 3] = 85;
            //mark[2, 0] = 90; mark[2, 1] = 95; mark[2, 2] = 93; mark[2, 3] = 89;
            //for (int i = 0; i < 3; i++)
            //{
            //    int totalMark = 0;
            //    for (int j = 0; j < 4; j++)
            //    {
            //        totalMark += mark[i, j];
            //    }
            //    total[i] = totalMark;
            //    average[i] = totalMark / 4;
            //}
            //int topScorer = 0;
            //for (int i = 1; i < 3; i++)
            //{
            //    if (total[i] > total[topScorer])
            //        topScorer = i;
            //}
            //Console.WriteLine("Student Marks Summary:\n");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Student {i + 1} Marks: ");
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{mark[i, j]} ");
            //    }
            //    Console.WriteLine($"\nTotal: {total[i]}, Average: {average[i]}");
            //    if (i == topScorer)
            //        Console.WriteLine("Top Score");
            //}











            //..............................................jagged array...................................................

            //...............monthly sales report............
            //int[][] sales = new int[4][];
            //sales[0] = new int[] { 1200, 950, 1430 };
            //sales[1] = new int[] { 1100, 1050}; 
            //sales[2] = new int[] { 1000, 1200, 1122 }; 
            //sales[3] = new int[] { 1500 };
            //Console.WriteLine("mothly sales report");
            //for (int i = 0; i < sales.Length; i++)
            //{

            //    Console.WriteLine($"Employee {i + 1} Sales:");
            //    int total = 0;
            //    for (int j = 0; j < sales[i].Length; j++)
            //    {
            //            Console.WriteLine($"  Transaction {j + 1}: {sales[i][j]}");
            //            total += sales[i][j];
            //    }

            //    int average = total / sales[i].Length;
            //    Console.WriteLine("#Total Sales is " +total);
            //    Console.WriteLine("#Average Sale " + average);
            //}

            //...................Bus Ticket Booking System...............................

            //int[][] seats = new int[3][];
            //seats[0] = new int[5];
            //seats[1] = new int[4];
            //seats[2] = new int[6];
            //int seatNo = 1;
            //for (int i = 0; i < seats.Length; i++)
            //{
            //    for (int j = 0; j < seats[i].Length; j++)
            //    {
            //        seats[i][j] = seatNo++;
            //    }
            //}
            //Console.WriteLine("Bus Seating Arrangement:\n");
            //for (int i = 0; i < seats.Length; i++)
            //{
            //    Console.Write($"Row {i + 1}: ");
            //    for (int j = 0; j < seats[i].Length; j++)
            //    {
            //        Console.Write(seats[i][j] + " ");
            //    }
            //    Console.WriteLine();

            //}

            //...............................enum.................................................
            //.........Employee Role Checker...........

            //Console.WriteLine("Enter a role: ");
            //string user = Console.ReadLine();
            //Enum.TryParse<EmployeeRole>(user, true, out EmployeeRole role);
            //if (role == EmployeeRole.manager)
            //{
            //    Console.WriteLine("Access Granted to Admin Panel!");
            //}
            //else
            //{
            //    Console.WriteLine("Limited Access");
            //}

            //....................pizza price calculator...................
            //Console.WriteLine("Select Pizza Size:");
            //int choice = int.Parse(Console.ReadLine());
            //PizzaSize selectedSize;

            //switch (choice)
            //{
            //    case 1:
            //        selectedSize = PizzaSize.Small;
            //        Console.WriteLine("price : 100");
            //        break;
            //    case 2:
            //        selectedSize = PizzaSize.Medium;
            //        Console.WriteLine("price : 150");
            //        break;
            //    case 3:
            //        selectedSize = PizzaSize.Large;
            //        Console.WriteLine("price : 200");
            //        break;
            //}

            //................Traffic Light Simulation....................
            //Console.WriteLine("Enter Traffic Signal (Red, Yellow, Green):");
            //string input = Console.ReadLine();
            //Enum.TryParse<TrafficSignal>(input, true, out TrafficSignal signal);
            //switch (signal)
            //{
            //    case TrafficSignal.Red:
            //        Console.WriteLine("Stop");
            //        break;
            //    case TrafficSignal.Yellow:
            //        Console.WriteLine("Get Ready");
            //        break;
            //    case TrafficSignal.Green:
            //        Console.WriteLine("Go");
            //        break;
            //}

            //.............................Exam Result Grading..................
            //Console.Write("Enter your exam score: ");
            //int score = int.Parse(Console.ReadLine());

            //Grade result;

            //if (score < 35)
            //{
            //    result = Grade.Fail;
            //}
            //else if (score >= 35 && score <= 59)
            //{
            //    result = Grade.Pass;
            //}
            //else 
            //{
            //    result = Grade.Distinction;
            //}

            //Console.WriteLine($"Your grade is: {result} ({(int)result})");

            //..........................................structure............................................
            //...................display student details...............
            //Student student1;
            //Console.WriteLine("enter student id : ");
            //student1.id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter student name : ");
            //student1.name =Console.ReadLine();
            //Console.WriteLine("enter mark : ");
            //student1.mark = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("id : " + student1.id);
            //Console.WriteLine("name : " + student1.name);
            //Console.WriteLine("mark : " + student1.mark);

            //..................Compare Two Employees................................

            employee employee1;
            employee1.empId = 23;
            employee1.empName= "alisha";
            employee1.salary = 5000;

            employee employee2;
            employee2.empId = 21;
            employee2.empName = "aleesha";
            employee2.salary = 500;

            if (employee1.salary >employee2.salary)
            {
                Console.WriteLine(employee1.empName+" has the higher  salary");
            }
            else if(employee2.salary > employee1.salary) 
            {
                Console.WriteLine(employee2.empName + " has the higher  salary");
            }










        }
    }
}


 
    

