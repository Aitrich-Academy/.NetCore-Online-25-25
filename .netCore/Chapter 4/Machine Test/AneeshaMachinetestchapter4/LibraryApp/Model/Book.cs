using System;
namespace LibraryApp.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool isAvailable { get; set; }

        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            isAvailable = true;

        }

        public void Borrow()
        {
            if (!isAvailable)
                throw new LibraryApp.Exceptions.LibraryException($"'{Title}' is already borrowed.");
            isAvailable = false;
        }
        public void Return()
        {
            if (isAvailable)
                throw new LibraryApp.Exceptions.LibraryException($"'{Title}' was not borrowed.");
            isAvailable = true;
        }

        public void Display()
        {
            Console.WriteLine($"{BookId},Title:{Title},Author:{Author},Available:{isAvailable}");
        }


    }
}