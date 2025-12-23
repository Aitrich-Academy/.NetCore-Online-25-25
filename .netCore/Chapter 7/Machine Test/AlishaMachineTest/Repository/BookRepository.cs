using AlishaMachineTest.Interface;
using AlishaMachineTest.Model;

namespace AlishaMachineTest.Repository
{
    public class BookRepository:IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
