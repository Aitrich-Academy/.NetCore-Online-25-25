using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Interface;
using AneeshaMachineTestLibrary.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AneeshaMachineTestLibrary.Pages.LibraryList;

public class Librarylist : PageModel
{
   private readonly IBookService _bookService;
   public List<BookDto> Library{get;set;}

   public Librarylist(IBookService bookService)
   {
      _bookService = bookService;
   }


   public async Task OnGetAsync()
   {
      Library = await _bookService.GetAllBooksAsync();
   }
}