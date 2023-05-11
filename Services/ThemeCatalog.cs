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
        }

        public Dictionary<int, Theme> AllThemes()
        {
            return themes;  
        }

        //public void AddTheme(Theme theme)
        //{
        //    if (!themes.Keys.Contains(theme.Id))
        //    {
        //        themes.Add(theme.Id, theme);
        //    }
        //}

        public void RemoveTheme(Theme theme)
        {
             
        }

        public void UpdateTheme(Theme theme)
        {

        }  
        
        //public Dictionary<int, Theme> SearchTheme(string criteria)
        //{
        //    Dictionary<int, Theme> searchThemes= new Dictionary<int, Theme>();
        //    if (criteria != null)
        //    {
        //        foreach (var t in themes.Values)
        //        {
        //            if (t.Name.StartWith(criteria))
        //            {
        //                searchThemes.Add(t.Id, t);
        //            }
        //        }
        //    }
        //    return searchThemes;  
        //}



    }
}
