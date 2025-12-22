using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Interface;
using AneeshaMachineTestLibrary.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AneeshaMachineTestLibrary.Pages.LibararyList;

public class Librarylist : PageModel
{
   private readonly IBookService _bookService;
   private List<BookDto> Library{get;set;}

   public Librarylist(IBookService bookService)
   {
      _bookService = bookService;
   }
   
   public List<BookDto> Library { get; set; }

   public async Task OnGetAsync()
   {
      Library = await _bookService.GetAllBooksAsync();
   }
}