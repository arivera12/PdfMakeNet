using Newtonsoft.Json;

namespace PdfMakeNet
{  
    public class PdfMakeLink : PdfMakeStyle
    {
        /// <summary>
        /// Adds a link
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
        /// <summary>
        /// Adds a link to a page
        /// </summary>
        [JsonProperty("linkToPage")]
        public int LinkToPage { get; set; }
    }
}
