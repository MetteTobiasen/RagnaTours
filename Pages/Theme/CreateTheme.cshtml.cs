using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Models;
using RagnaTours.Pages;
using RagnaTours.Services;

namespace RagnaTours
{
    public class CreateThemeModel : PageModel
    {
        [BindProperty]
        public Theme Theme { get; set; }
        private IThemeRepository catalog;
        public CreateThemeModel(IThemeRepository repository)
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

            catalog.AddTheme(Theme);

            return RedirectToPage("GetAllThemes");
        }
    }
}
