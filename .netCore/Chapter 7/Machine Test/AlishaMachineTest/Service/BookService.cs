using AlishaMachineTest.Interface;

namespace AlishaMachineTest.Service
{
    public class BookService:IBookService
    {
        private IBookRepository repository;
        public BookService(IBookRepository _repository)
        {
            _repository = repository;
        }
    }
}
