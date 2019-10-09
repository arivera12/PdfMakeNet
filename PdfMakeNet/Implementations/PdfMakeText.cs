using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeText : PdfMakeStyle
    {
        /// <summary>
        /// Adds text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
