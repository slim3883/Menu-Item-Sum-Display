using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonParser
{
    public class Menu
    {
        public Menu()
        {
            Items = new List<Item>();
        }
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }
}