using Newtonsoft.Json;

namespace PdfMakeCSharp
{  
    public class PdfMakeLink : PdfMakeStyle
    {
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("linkToPage")]
        public int LinkToPage { get; set; }
    }
}
