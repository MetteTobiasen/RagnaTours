using System.Xml;
using Newtonsoft.Json;
using RagnaTours.Models;
using System.IO;
using System.Collections.Generic;

namespace RagnaTours.Helpers
{
    public class JsonFileWriter
    {
            public static void WriteToJson(Dictionary<int, Exhibition> exhibitions, string JsonFileName)
            {
                string output = JsonConvert.SerializeObject(exhibitions, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(JsonFileName, output);
            }

       
    }
}
