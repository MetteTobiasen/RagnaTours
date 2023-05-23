using Newtonsoft.Json;
using RagnaTours.Models;

namespace RagnaTours.Helpers
{
    public class JsonFileWriterTheme
    {
        public static void WriteToJson(Dictionary<int, Theme> themes, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(themes, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(JsonFileName, output);
        }
    }
}
