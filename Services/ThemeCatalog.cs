using RagnaTours.Interfaces;
using RagnaTours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RagnaTours.Services

{
    public class ThemeCatalog : IThemeRepository
    {
        private Dictionary<int, Theme> themes { get;}

        public ThemeCatalog()
        {
            themes = new Dictionary<int, Theme>();
            themes.Add(1, new Theme() {Id = 1, Name = "Ragnerock", Description = "test test test", ImageName = "RagnerockUdstilling"  });
            themes.Add(2, new Theme() {Id = 2, Name = "Roskilde Festival", Description = "test test test", ImageName = "RoskildeFestival" });
            themes.Add(3, new Theme() {Id = 3, Name = "Skanderborg Festival", Description = "test test test", ImageName = "SkanderborgFestival" });
        }

        public Dictionary<int, Theme> AllThemes()
        {
            return themes;  
        }

        public void AddTheme(Theme theme)
        {
            if (!themes.Keys.Contains(theme.Id))
            {
                themes.Add(theme.Id, theme);
            }
        }

        public Theme GetTheme(int id)
        {
            return themes[id];
        }

        public void DeleteTheme(Theme theme)
        {
             if(theme != null)
            {
                themes.Remove(theme.Id);    
            }
        }

        public void UpdateTheme(Theme theme)
        {
            if (theme != null)
            {
                themes[theme.Id] = theme;
            }
        }

        public Dictionary<int, Theme> SearchTheme(string criteria)
        {
            Dictionary<int, Theme> searchThemes = new Dictionary<int, Theme>();
            if (criteria != null)
            {
                foreach (var t in themes.Values)
                {
                    if (t.Name.StartsWith(criteria))
                    {
                        searchThemes.Add(t.Id, t);
                    }
                }
            }
            return searchThemes;
        }

    }
}
