using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Model;

namespace LibraryApp.Services
{
    public class SearchService
    {
        private static object b;

        public static void SearchBooks(List<Book>books,string keyword)

        {
            var result = books.Where(b => b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                                       || b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase));



            if (!result.Any())
            {
                Console.WriteLine("No matching books found.");
                return;
            }

            Console.WriteLine("search Results:");
            foreach (var book in result)
            {
                book.Display();
            }
        }
    }
}

