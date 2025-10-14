using alishaWorkshop1.Interface;
using alishaWorkshop1.Manager;
using alishaWorkshop1.Interface;
using alishaWorkshop1.Manager;

namespace alishaWorkshop1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }
    }
}

