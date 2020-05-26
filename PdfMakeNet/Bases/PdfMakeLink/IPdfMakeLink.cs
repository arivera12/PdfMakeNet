using Newtonsoft.Json;

namespace PdfMakeNet
{  
    public interface IPdfMakeLink : IPdfMakeStyle
    {
        /// <summary>
        /// Adds a link
        /// </summary>
        [JsonProperty("link")]
        string Link { get; set; }
        /// <summary>
        /// Adds a link to a page
        /// </summary>
        [JsonProperty("linkToPage")]
        int LinkToPage { get; set; }
    }
}
