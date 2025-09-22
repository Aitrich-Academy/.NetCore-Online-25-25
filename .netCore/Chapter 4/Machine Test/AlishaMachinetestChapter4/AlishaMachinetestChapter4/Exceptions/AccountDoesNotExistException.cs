using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlishaMachinetestChapter4.Exceptions
{
    public class AccountDoesNotExistException:Exception
    {
        public AccountDoesNotExistException(string message) : base(message){ }
    }
}
