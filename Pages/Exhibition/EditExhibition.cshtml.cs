using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Pages;
using RagnaTours.Services;
using RagnaTours.Models;

namespace RagnaTours
{
    public class EditExhibitionModel : PageModel
    {

        [BindProperty]
        public Exhibition Exhibition { get; set; }
        IExhibitionRepository exhibition;
        public EditExhibitionModel(IExhibitionRepository repository)
        {
            exhibition = repository;
        }
        public void OnGet(int id)
        {
            Exhibition = exhibition.GetExhibition(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            exhibition.UpdateExhibition(Exhibition);
            return RedirectToPage("GetAllExhibitions");
        }
    }
}
