using AneeshaMachineTestLibrary.Interface;
using AneeshaMachineTestLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace AneeshaMachineTestLibrary.Repository;

public class BookRepository : IBookRepository
{
    private readonly BookDbContext _dbcontext;

    public BookRepository(BookDbContext dbContext)
    {
        _dbcontext = dbContext;
    }

    public async Task<List<Book>> GetAllBooksAsync()
    {
        return await _dbcontext.Books.ToListAsync();
    }

    


    public async Task<Book?> GetBookByIdAsync(int id)
    {
        return await _dbcontext.Books.FindAsync(id);
    }

    public async Task AddBookAsync(Book book)
    {
        _dbcontext.Books.Add(book);
        await _dbcontext.SaveChangesAsync();
    }

    public async Task DeleteBookAsync(int id)
    {
        var book = await _dbcontext.Books.FindAsync(id);
        if (book != null)
        {
            _dbcontext.Books.Remove(book);
            await _dbcontext.SaveChangesAsync();
        }
    }
}