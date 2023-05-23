using Newtonsoft.Json;
using RagnaTours.Models;

namespace RagnaTours.Helpers
{
    public class JsonFileReaderTheme
    {
     
        public static Dictionary<int, Theme> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<Dictionary<int, Theme>>(jsonString);
        }
        
    }
}
