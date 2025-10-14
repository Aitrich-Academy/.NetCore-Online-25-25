using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alishaWorkshop1.Exceptions
{
    [Serializable]
    public class UserAlreadyExistException : Exception
    {
        public UserAlreadyExistException()
        {

        }
        public UserAlreadyExistException(string email)
             : base(String.Format("User Already Exist with this email{0} ", email))
        {

        }
    }
}

