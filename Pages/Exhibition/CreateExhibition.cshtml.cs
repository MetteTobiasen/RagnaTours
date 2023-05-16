using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Models;
using RagnaTours.Pages;
using RagnaTours.Services;

namespace RagnaTours
{
    public class CreateExhibitionModel : PageModel
    {
        [BindProperty]
        public Exhibition Exhibition { get; set; }
        private IExhibitionRepository catalog;
        public CreateExhibitionModel(IExhibitionRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            catalog.AddExhibition(Exhibition);

            return RedirectToPage("GetAllExhibitions");
        }
    }
}
