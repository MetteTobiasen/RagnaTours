using RagnaTours.Services;

namespace RagnaTours.Models
{
    public class Exhibition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        private Dictionary<int, Exhibition> exhibition { get; }

        //public ExhibitionCatalog() 
        //{ 
        //    exhibition = new Dictionary<int, Exhibition>();
        //}
    }
}
