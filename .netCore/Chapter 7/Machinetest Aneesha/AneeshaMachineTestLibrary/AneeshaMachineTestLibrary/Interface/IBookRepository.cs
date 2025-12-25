using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Model;

namespace AneeshaMachineTestLibrary.Interface;

public interface IBookRepository
{
    Task<List<Book>> GetAllBooksAsync();
    Task<Book> GetBookByIdAsync(int id);
    Task AddBookAsync(Book book);

    Task DeleteBookAsync(int id);
    
}