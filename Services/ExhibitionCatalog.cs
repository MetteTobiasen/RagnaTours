using RagnaTours.Interfaces;
using RagnaTours.Models;
using RagnaTours.Pages;
using System.Collections.Generic;

namespace RagnaTours.Services
{
    public class ExhibitionCatalog : IExhibitionRepository
    {
        private Dictionary<int, Exhibition> exhibitions { get; }

        public ExhibitionCatalog()
        {
            exhibitions = new Dictionary<int, Exhibition>();
            exhibitions.Add(1, new Exhibition() { Id = 1, Name = "TV2 Studie", Description = "test testes", ImageName = "TV2.JPEG" });
        }

        public Dictionary<int, Exhibition> AllExhibition()
        {
            return exhibitions;
        }

        public void AddExhibition(Exhibition exhibition)
        {
            if (!(exhibitions.Keys.Contains(exhibition.Id)))
                exhibitions.Add(exhibition.Id, exhibition);
        }

        public Exhibition GetExhibition(int id)
        {
            return exhibitions[id];
        }

        public List<Exhibition> FilterThemeName(List<Exhibition> exhibitions, string desiredTheme)
        {
            List<Exhibition> filteredExhibitions = new List<Exhibition>();

            foreach (Exhibition exhibition in exhibitions)
            {
                if (exhibition.ThemeName == desiredTheme)
                {
                    filteredExhibitions.Add(exhibition);
                }
            }

            return filteredExhibitions;
        }

        public void UpdateExhibition(Exhibition exhibition)
        {
            if (exhibition != null)
            {
                exhibitions[exhibition.Id] = exhibition;
            }
        }

        public void DeleteExhibition(Exhibition exhibition)
        {
            if (exhibition != null)
            {
                exhibitions.Remove(exhibition.Id);
            }
        }


        public Dictionary<int, Exhibition> FilterExhibition(string criteria)
        {
            Dictionary<int, Exhibition> myExhibitions = new Dictionary<int, Exhibition>();
            if (criteria != null)
            {
                foreach (var e in exhibitions.Values)
                {
                    if (e.Name.ToLower().StartsWith(criteria.ToLower()))
                    {
                        myExhibitions.Add(e.Id, e);
                    }
                }
            }
            return myExhibitions;
        }

        

    }
}
