using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeTableOfContent
    {
        /// <summary>
        /// Adds a table of content
        /// </summary>
        [JsonProperty("toc")]
        PdfMakeToc Toc { get; set; }
    }
}
