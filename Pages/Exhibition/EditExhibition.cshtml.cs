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
        IExhibitionRepository exhibition;

        [BindProperty]
        public Exhibition Exhibition { get; set; }
        public EditExhibitionModel(IExhibitionRepository ex)
        {
            exhibition = ex;
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
