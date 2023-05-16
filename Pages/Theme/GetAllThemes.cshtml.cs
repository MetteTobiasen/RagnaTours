using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RagnaTours.Interfaces;
using RagnaTours.Models;

namespace RagnaTours
{
    public class GetAllThemesModel : PageModel
    {
        private IThemeRepository catalog;
        public GetAllThemesModel(IThemeRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<int, Theme> Themes { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }

        public IActionResult OnGet()
        {
            Themes = catalog.AllTheme();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Themes = catalog.FilterTheme(FilterCriteria);
            }

            return Page();
        }
    }
}
