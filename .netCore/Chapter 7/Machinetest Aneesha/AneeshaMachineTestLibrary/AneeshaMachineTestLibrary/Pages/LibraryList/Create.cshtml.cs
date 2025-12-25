using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Interface;
using AneeshaMachineTestLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AneeshaMachineTestLibrary.Pages.LibraryList;

public class Create : PageModel
{
    private readonly IBookService _bookService;
    [BindProperty]
    public BookDto Library { get; set; }

    public Create(IBookService bookService)
    {
        _bookService = bookService;
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (!ModelState.IsValid)
            return Page();
        await _bookService.AddBookAsync(Library);
        return RedirectToPage("Librarylist");
    }

}