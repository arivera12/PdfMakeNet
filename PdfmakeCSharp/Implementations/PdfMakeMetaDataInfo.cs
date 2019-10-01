using Newtonsoft.Json;

namespace PdfMakeCSharp
{
    public class PdfMakeMetaDataInfo
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("JsonPropertywords")]
        public string JsonPropertywords { get; set; }
        [JsonProperty("creator")]
        public string Creator { get; set; }
        [JsonProperty("producer")]
        public string Producer { get; set; }
        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }
        [JsonProperty("modDate")]
        public string ModDate { get; set; }
        [JsonProperty("trapped")]
        public bool Trapped { get; set; }
    }
}
