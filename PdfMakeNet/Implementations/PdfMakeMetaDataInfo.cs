using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeMetaDataInfo
    {
        /// <summary>
        /// The title of the document
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// The name of the author
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }
        /// <summary>
        /// The subject of the document
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }
        /// <summary>
        /// Keywords associated with the document
        /// </summary>
        [JsonProperty("keywords ")]
        public string Keywords { get; set; }
        /// <summary>
        /// The creator of the document (default is ‘pdfmake’)
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }
        /// <summary>
        /// The producer of the document (default is ‘pdfmake’)
        /// </summary>
        [JsonProperty("producer")]
        public string Producer { get; set; }
        /// <summary>
        /// The date the document was created (added automatically by pdfmake)
        /// </summary>
        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }
        /// <summary>
        /// The date the document was last modified
        /// </summary>
        [JsonProperty("modDate")]
        public string ModDate { get; set; }
        /// <summary>
        /// The trapped flag in a PDF document indicates whether the document has been “trapped”, i.e. corrected for slight color misregistrations
        /// </summary>
        [JsonProperty("trapped")]
        public bool Trapped { get; set; }
    }
}
