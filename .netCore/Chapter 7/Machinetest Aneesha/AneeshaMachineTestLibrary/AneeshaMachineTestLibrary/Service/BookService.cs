using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Interface;
using AneeshaMachineTestLibrary.Model;
using AutoMapper;

namespace AneeshaMachineTestLibrary.Service;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public BookService(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<List<BookDto>> GetAllBooksAsync()
    {
        var books = await _bookRepository.GetAllBooksAsync();
        return _mapper.Map<List<BookDto>>(books);
    }
  
    public async Task AddBookAsync(BookDto bookDto)
    {
        var book = _mapper.Map<Book>(bookDto);
        await _bookRepository.AddBookAsync(book);
    }

    public async Task<BookDto?> GetBookByIdAsync(int id)
    {
        var book = await _bookRepository.GetBookByIdAsync(id);
        
        if (book == null)
            return null;
        
        return _mapper.Map<BookDto?>(book);
    }

   

    public async Task DeleteBookAsync(int id)
    {
        await _bookRepository.DeleteBookAsync(id);
    }
}