using AneeshaMachineTestLibrary.DTO;
using AneeshaMachineTestLibrary.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AneeshaMachineTestLibrary.Pages.LibararyList;

public class Create : PageModel
{
    private readonly IBookService bookservice;
    [BindProperty]
    public BookDto Book { get; set; }

    public Create(IBookService bookService)
    {
        _bookService = bookService;
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (!ModelState.IsValid)
            return Page();
        await _bookService.AddBookAsync(Book);
        return RedirectToPage("Librarylist");
    }

}