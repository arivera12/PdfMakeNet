using Newtonsoft.Json;

namespace PdfMakeCSharp
{
    public class PdfMakeImage : PdfMakeStyle
    {
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
