using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeInfoWebApp.Models;
using EmployeeInfoWebApp.Repositories;

namespace EmployeeInfoWebApp.Pages
{
    public class EmployeeInfoCreateModel : PageModel
    {
        private readonly EmployeeInfoRepository _repository;

        public EmployeeInfoCreateModel(EmployeeInfoWebApp.Models.EmployeeInfoWebAppContext context)
        {
            _repository = new EmployeeInfoRepository(context);
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
            await _repository.Create(EmployeeInfo);

            return Page();
        }
    }
}