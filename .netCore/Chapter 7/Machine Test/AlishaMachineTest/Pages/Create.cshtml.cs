using AlishaMachineTest.Dto;
using AlishaMachineTest.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlishaMachineTest.Pages
{
    public class CreateModel : PageModel
    {
        private IBookService service;

        public CreateModel(IBookService _service)
        {
            _service = service;
        }
        [BindProperty]
        public BookDto Book { get; set; }
    }
}
