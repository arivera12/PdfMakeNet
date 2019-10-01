using Newtonsoft.Json;

namespace PdfMakeCSharp
{
    public class PdfMakeTableOfContent
    {
        [JsonProperty("toc")]
        public PdfMakeToc Toc { get; set; }
    }
}
