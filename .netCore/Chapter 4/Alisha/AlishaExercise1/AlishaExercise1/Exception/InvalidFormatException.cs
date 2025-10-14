using System;

namespace AlishaExercise1.Exceptions
{
    public class InvalidFormatException : ApplicationException
    {
        public InvalidFormatException(string message) : base(message) { }
    }
}


