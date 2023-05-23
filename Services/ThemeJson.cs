using Newtonsoft.Json;
using RagnaTours.Interfaces;
using RagnaTours.Models;
using RagnaTours.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;



namespace RagnaTours.Services
    
{
    public class ThemeJson : IThemeRepository
    {
        public Dictionary<int, Theme> AllThemes()
        {
            return JsonFileReaderTheme.ReadJson(@"Data\JsonThemes.json");
        }

        public void AddTheme(Theme theme)
        {
            Dictionary<int, Theme> themes = AllThemes();
            if (!(themes.Keys.Contains(theme.Id))) 
                themes.Add(theme.Id, theme);
            JsonFileWriterTheme.WriteToJson(themes, @"Data\JsonThemes.json");
        }
        public Theme GetTheme(int id) 
        {
            Dictionary<int, Theme> themes = AllThemes();
            foreach (var t in themes) 
            { 
                if (t.Key == id) 
                return t.Value;
            }
            return new Theme();
        }
        public void DeleteTheme(Theme theme) 
        { 
            Dictionary<int, Theme> myThemes = AllThemes();
            foreach (var t in myThemes.Values) 
            {
                if (t.Id == theme.Id) 
                {
                    myThemes.Remove(t.Id);
                }
            }
            JsonFileWriterTheme.WriteToJson(myThemes, @"Data\JsonThemes.json");
        }
        public void UpdateTheme(Theme theme)
        {
            Dictionary<int, Theme> themes = AllThemes();
            foreach (var t in themes.Values)
            {
                if (t.Id == theme.Id)
                {
                    t.Id= theme.Id;
                    t.Name = theme.Name;
                    t.Description= theme.Description;   
                    t.ImageName = theme.ImageName;
                }
            }
            JsonFileWriterTheme.WriteToJson(themes, @"Data\JsonThemes.json");

        }
        public Dictionary<int, Theme> SearchTheme(string criteria)
        {
            Dictionary<int, Theme> myTheme = AllThemes();
            if (criteria != null)
            {
                foreach (var t in myTheme.Values)
                {
                    if (t.Name.StartsWith(criteria))
                    {
                        myTheme.Add(t.Id, t);
                    }
                }
            }
            return myTheme;
        }
    }
}
