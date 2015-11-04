using Newtonsoft.Json;

namespace JsonParser
{
    public class JsonMenu
    {
        [JsonProperty("menu")]
        public Menu Menu { get; set; }
    }
}