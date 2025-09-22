using System;
//System.Collections.Generic;
//System.Linq
using LibraryApp.Exceptions;
using LibraryApp.Model;

namespace LibraryApp.Repositories
{
    public class LibraryRepository
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book'{book.Title}'added successfully");

        }

        public void RemoveBook(int bookId)
        {
            Book book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
                throw new LibraryApp.Exceptions.LibraryException($"Book with ID{bookId} not found.");
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title})'removed successfully.");
        }

        public void BorrowBook(int bookId)
        {
            Book book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
                throw new LibraryApp.Exceptions.LibraryException($"Book with ID {bookId} not found.");
            book.Borrow();
            Console.WriteLine($"You borrowed '{book.Title}'.");
        }



        public void ReturnBook(int bookId)
        {
            Book book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
                throw new LibraryApp.Exceptions.LibraryException($"Book with ID {bookId} not found.");
            book.Return();
            Console.WriteLine($"you returned'{book.Title}'.");

        }

        public void DisplayAllBooks()
        {
            if (!books.Any())
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            Console.WriteLine("Library Books:");
            foreach (Book book in books)


            {
                book.Display();
            }
        }



        public List<Book> GetBooks() => books;

    }

}