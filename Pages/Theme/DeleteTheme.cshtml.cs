using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Models;
using RagnaTours.Pages;

namespace RagnaTours
{
    public class DeleteThemeModel : PageModel
    {

        [BindProperty]
        public Theme Theme { get; set; }
        private IThemeRepository catalog;
        public DeleteThemeModel(IThemeRepository repository)
        {
            catalog = repository;
        }
        public IActionResult OnGet(int id)
        {
            Theme = catalog.GetTheme(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.DeleteTheme(Theme);
            return RedirectToPage("GetAllThemes");
        }
    }
}
