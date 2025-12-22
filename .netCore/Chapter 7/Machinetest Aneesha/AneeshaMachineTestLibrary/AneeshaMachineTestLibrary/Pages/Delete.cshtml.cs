using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Interface;
using AneeshaMachineTestLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AneeshaMachineTestLibrary.Pages;

public class Delete : PageModel
{
    private readonly IBookService _bookService;
    public Delete(IBookService bookService)
        {
        _bookService = bookService;
        }
    
    [BindProperty]
    
    public BookDto Book { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (Library == null)
        {
            return NotFound();
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int CompanyMemberId)
    {
        await _service.DeleteBookAsync(CompanyMemberId);
        return RedirectToPage("Memberlist");
    }
    
}