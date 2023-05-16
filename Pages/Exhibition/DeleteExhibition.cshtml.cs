using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Models;
using RagnaTours.Pages;

namespace RagnaTours
{
    public class DeleteExhibitionModel : PageModel
    {

        [BindProperty]
        public Exhibition Exhibition { get; set; }
        private IExhibitionRepository catalog;
        public DeleteExhibitionModel(IExhibitionRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet(int id)
        {
            Exhibition = catalog.GetExhibition(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.DeleteExhibition(Exhibition);
            return RedirectToPage("GetAllExhibitions");
        }
    }
}
