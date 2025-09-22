using LibraryApp.Exceptions;
using LibraryApp.Model;
using LibraryApp.Repositories;
using LibraryApp.Services;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryRepository library = new LibraryRepository();
            SearchService searchService = new SearchService();  

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("---Library Menu---");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Remove Book");
                Console.WriteLine("3.Borrow Book");
                Console.WriteLine("4.Return Book");
                Console.WriteLine("5.Search Books");
                Console.WriteLine("6.Display All Books");
                Console.WriteLine("7.Exit");
                Console.WriteLine("Enter your choice:");

                string input = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    switch (input)
                    {
                        case "1":
                            Console.Write("Enter Book ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();
                            library.AddBook(new Book(id, title, author));
                            break;

                        case "2":
                            Console.Write("Enter Book ID to remove: ");
                            int removeId = int.Parse(Console.ReadLine());
                            library.RemoveBook(removeId);
                            break;

                        case "3":
                            Console.Write("Enter Book ID to borrow: ");
                            int borrowId = int.Parse(Console.ReadLine());
                            library.BorrowBook(borrowId);
                            break;

                        case "4":
                            Console.Write("Enter Book ID to return: ");
                            int returnId = int.Parse(Console.ReadLine());
                            library.ReturnBook(returnId);
                            break;

                        case "5":
                            Console.Write("Enter Keyword (Title/Author): ");
                            string keyword = Console.ReadLine();
                            SearchService.SearchBooks(library.GetBooks(), keyword); 
                            break;

                        case "6":
                            library.DisplayAllBooks();
                            break;

                        case "7":
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please enter 1-7.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
                catch (LibraryException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error: " + ex.Message);
                }
            }

            Console.WriteLine("Exiting Library Application.");
        }
    }
}
