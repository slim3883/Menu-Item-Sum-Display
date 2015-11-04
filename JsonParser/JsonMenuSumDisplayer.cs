using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace JsonParser
{
    public class JsonMenuSumDisplayer : IDisplayer
    {
        public void Display(string fileLocation)
        {
            using (var r = new StreamReader(fileLocation))
            {
                string json = r.ReadToEnd();
                var jsonObjects = JsonConvert.DeserializeObject<List<JsonMenu>>(json);
                var numberExtractor = new NumberExtractor();
                foreach (var jsonObject in jsonObjects)
                {
                    var numbersToAdd = numberExtractor.ExtractNumbersToAdd(jsonObject.Menu);
                    Console.WriteLine(numbersToAdd.Sum());
                }
                Console.ReadLine();
            }
        }
    }
}