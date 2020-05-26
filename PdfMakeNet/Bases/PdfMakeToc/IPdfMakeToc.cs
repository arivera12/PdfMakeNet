using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeToc
    {
        /// <summary>
        /// Id od the table of content
        /// </summary>
        [JsonProperty("id")]
        string Id { get; set; }
        /// <summary>
        /// The title of table of content
        /// </summary>
        [JsonProperty("title")]
        PdfMakeText Title { get; set; }
    }
}
