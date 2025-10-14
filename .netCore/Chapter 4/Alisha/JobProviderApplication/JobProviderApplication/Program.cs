using JobProviderApplication.Managers;
using JobProviderApplication.Models;

namespace JobProviderApplication
{
    internal class Program
    {
        static void Main(string[] args)
            {
                JobPortal portal = new JobPortal();
                Printer printer = new Printer();
                portal.AddApplication(new Application { Id = 1, Name = "Alisha", Location = "Kochi", Qualification = "B.Tech", Experience = "2 Years" });
                portal.AddApplication(new Application { Id = 2, Name = "Anna", Location = "Tvm", Qualification = "M.Tech", Experience = "3 Years" });
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\n Job Portal Menu ");
                    Console.WriteLine("1. Post Job");
                    Console.WriteLine("2. List Job");
                    Console.WriteLine("3. List Applications");
                    Console.WriteLine("4. Schedule Interviews");
                    Console.WriteLine("5. List Interview");
                    Console.WriteLine("6. Exit");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                        Console.Write("Enter Job Id: ");
                        int jobId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Description: ");
                        string desc = Console.ReadLine();
                        Console.Write("Enter Location: ");
                        string loc = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        string salary = Console.ReadLine();
                        Console.Write("Enter Type: ");
                        string type = Console.ReadLine();
                        Console.Write("Enter Company: ");
                        portal.PostJob(new Job
                        {
                            Id = jobId,
                            Title = title,
                            Description = desc,
                            Location = loc,
                            Salary = salary,
                            Type = type,
                            
                        });
                        string company = Console.ReadLine();
                        Console.WriteLine("Job posted successfully!");
                        break;
                        

                        case "2":
                        printer.Print(portal.GetJobs());
                        break;

                    case "3":
                            printer.Print(portal.GetApplications());
                            break;

                        case "4":
                        Console.Write("Enter Interview Id: ");
                        int intId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Company: ");
                        string intCompany = Console.ReadLine();
                        Console.Write("Enter Post: ");
                        string intPost = Console.ReadLine();
                        Console.Write("Enter Date: ");
                        string intDate = Console.ReadLine();
                        Console.Write("Enter Time: ");
                        string intTime = Console.ReadLine();
                        Console.Write("Enter Location: ");
                        string intLoc = Console.ReadLine();
                        portal.ScheduleInterview(new Interview
                        {
                            Id = intId,
                            Company = intCompany,
                            Post = intPost,
                            Date = intDate,
                            Time = intTime,
                            Location = intLoc
                        });
                        Console.WriteLine("Interview scheduled successfully!");
                        break;
                        printer.Print(portal.GetInterviews());
                            break;

                        case "5":
                        printer.Print(portal.GetInterviews());
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;




                }
            }
            }
        }
    }
