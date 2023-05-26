using RagnaTours.Interfaces;
using RagnaTours.Models;
using RagnaTours.Helpers;

namespace RagnaTours.Services
{
    public class ExhibitionJson : IExhibitionRepository
    {
        public Dictionary<int, Exhibition> AllExhibition()
        {
            return JsonFileReader.ReadJson(@"Data\JsonExhibitions.json");
        }

        public void AddExhibition(Exhibition exhibition)
        {
            Dictionary<int, Exhibition> exhibitions = AllExhibition();
            if (!(exhibitions.Keys.Contains(exhibition.Id)))
                exhibitions.Add(exhibition.Id, exhibition);
            JsonFileWriter.WriteToJson(exhibitions, @"Data\JsonExhibitions.json");
        }
        public Exhibition GetExhibition(int id)
        {
            Dictionary<int, Exhibition> exhibitions = AllExhibition();
            foreach (var e in exhibitions)
            {
                if (e.Key == id)
                    return e.Value;
            }
            return new Exhibition();
        }
        public void DeleteExhibition(Exhibition exhibition)
        {
            Dictionary<int, Exhibition> myExhibitions = AllExhibition();
            foreach (var e in myExhibitions.Values)
            {
                if (e.Id == exhibition.Id)
                {
                    myExhibitions.Remove(e.Id);
                }
            }
            JsonFileWriter.WriteToJson(myExhibitions, @"Data\JsonExhibitions.json");
        }
        public void UpdateExhibition(Exhibition exhibition)
        {
            Dictionary<int, Exhibition> exhibitions = AllExhibition();
            foreach (var e in exhibitions.Values)
            {
                if (e.Id == exhibition.Id)
                {
                    e.Id = exhibition.Id;
                    e.Name = exhibition.Name;
                    e.Description = exhibition.Description;
                    e.ImageName = exhibition.ImageName;
                }
            }
            JsonFileWriter.WriteToJson(exhibitions, @"Data\JsonExhibitions.json");

        }
        public Dictionary<int, Exhibition> FilterExhibition(string criteria)
        {
            Dictionary<int, Exhibition> myExhibitions = AllExhibition();
            Dictionary<int, Exhibition> filteredExhibitions = new Dictionary<int, Exhibition>();
            if (criteria != null)
            {
                foreach (var e in myExhibitions.Values)
                {
                    if (e.Name.ToLower().StartsWith(criteria.ToLower()))
                    {
                        filteredExhibitions.Add(e.Id, e);
                    }
                }
            }
            return filteredExhibitions;
        }
    }
}
