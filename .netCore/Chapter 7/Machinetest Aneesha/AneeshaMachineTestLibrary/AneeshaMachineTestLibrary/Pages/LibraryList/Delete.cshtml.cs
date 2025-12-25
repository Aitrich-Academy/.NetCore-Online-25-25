using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AneeshaMachineTestLibrary.Pages.LibraryList;

public class Delete : PageModel
{
    private readonly IBookService _bookService;
    public Delete(IBookService bookService)
    {
        _bookService = bookService;
    }
    
    [BindProperty]
    
    public BookDto Library { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        Library = await _bookService.GetBookByIdAsync(id.Value);
        if (Library == null)
        {
            return NotFound();
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        await _bookService.DeleteBookAsync(id);
        return RedirectToPage("Librarylist");
    }

}