using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeToc : IPdfMakeToc
    {
        /// <summary>
        /// Id od the table of content
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// The title of table of content
        /// </summary>
        [JsonProperty("title")]
        public PdfMakeText Title { get; set; }
    }
}
