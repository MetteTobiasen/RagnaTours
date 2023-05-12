using RagnaTours.Models;

namespace RagnaTours.Interfaces
{
    public interface IExhibitionRepository
    {
        Dictionary<int, Exhibition> AllExhibition();
        void AddExhibition(Exhibition exhibition);
        Exhibition GetExhibition(int id);
        void UpdateExhibition(Exhibition exhibition);
        void DeleteExhibition(Exhibition exhibition);
        Dictionary<int, Exhibition> FilterExhibition(string criteria);
    }
}
