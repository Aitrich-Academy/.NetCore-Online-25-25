using AlishaMachineTest.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlishaMachineTest.Pages
{
    public class Index1Model : PageModel
    {
    
        private IBookService service;

        public Index1Model(IBookService _service)
        {
            _service = service;
        }
    }
}
