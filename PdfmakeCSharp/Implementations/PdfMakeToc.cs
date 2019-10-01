using Newtonsoft.Json;

namespace PdfMakeCSharp
{
    public class PdfMakeToc
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public PdfMakeText Title { get; set; }
    }
}
