using RagnaTours.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;



namespace RagnaTours.Helpers
{
    public class JsonFileReader
    {
        public static Dictionary<int, Exhibition> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<Dictionary<int, Exhibition>>(jsonString);
        }
    }
}
