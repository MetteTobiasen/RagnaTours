using RagnaTours.Models;

namespace RagnaTours.Interfaces
{
    public interface IExhibitionRepository
    {
        public Dictionary<int, Exhibition> AllExhibition();
        public void AddExhibition(Exhibition exhibition);
        public Exhibition GetExhibition(int id);
        public void UpdateExhibition(Exhibition exhibition);
        public void DeleteExhibition(Exhibition exhibition);
        public Dictionary<int, Exhibition> FilterExhibition(string criteria);
    }
}
