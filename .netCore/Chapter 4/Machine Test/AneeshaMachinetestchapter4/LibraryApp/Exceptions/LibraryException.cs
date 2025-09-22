using System;
namespace LibraryApp.Exceptions
{
    public class LibraryException : Exception
    {
        public LibraryException(string message) : base(message)
        {
        }
    }
}

