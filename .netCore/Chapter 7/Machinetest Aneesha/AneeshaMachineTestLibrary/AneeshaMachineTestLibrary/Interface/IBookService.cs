using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Model;

namespace AneeshaMachineTestLibrary.Interface;

public interface IBookService
{
    Task<List<BookDto>> GetAllBooksAsync();
    Task<BookDto> GetBookByIdAsync(int id);
    Task AddBookAsync(BookDto book);
    Task DeleteBookAsync(int id);

}