using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeTableOfContent : IPdfMakeTableOfContent
    {
        /// <summary>
        /// Adds a table of content
        /// </summary>
        [JsonProperty("toc")]
        public PdfMakeToc Toc { get; set; }
    }
}
