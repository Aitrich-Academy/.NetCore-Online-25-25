using Microsoft.EntityFrameworkCore;

namespace AneeshaMachineTestLibrary.Model;


    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options){}
        public DbSet<Book> Books { get; set; }
    }
    
