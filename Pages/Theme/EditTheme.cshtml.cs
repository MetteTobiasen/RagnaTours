using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Models;

namespace RagnaTours
{
        public class EditThemeModel : PageModel
        {
            IThemeRepository theme;

            [BindProperty]
            public Theme Theme { get; set; }
            public EditThemeModel(IThemeRepository themes)
            {
                theme = themes;
            }
            public void OnGet(int id)
            {
                Theme = theme.GetTheme(id);
            }

            public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                theme.UpdateTheme(Theme);
                return RedirectToPage("GetAllThemes");
            }
        }
}
