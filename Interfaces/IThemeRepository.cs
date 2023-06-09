﻿using RagnaTours.Models;

namespace RagnaTours.Interfaces
{
    public interface IThemeRepository
    {
        Dictionary<int, Theme> AllThemes();
        void AddTheme(Theme theme);
        Theme GetTheme(int id);
        void DeleteTheme(Theme theme);
        void UpdateTheme(Theme theme);
        Dictionary<int, Theme> SearchTheme(string criteria);
    }
}
