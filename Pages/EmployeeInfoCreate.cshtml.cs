using System.Threading.Tasks;
using EmployeeInfoWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeInfoWebApp.Services;

namespace EmployeeInfoWebApp.Pages
{
    public class EmployeeInfoCreateModel : PageModel
    {
        private readonly IEmployeeInfoService _service;

        public EmployeeInfoCreateModel(IEmployeeInfoService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EmployeeInfo EmployeeInfo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Application service
            await _service.Create(EmployeeInfo);

            return Page();
        }
    }
}