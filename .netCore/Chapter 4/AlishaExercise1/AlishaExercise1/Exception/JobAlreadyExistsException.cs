using System;

namespace AlishaExercise1.Exceptions
{
    public class JobAlreadyExistsException : ApplicationException
    {
        public JobAlreadyExistsException(string message) : base(message) { }
    }
}

