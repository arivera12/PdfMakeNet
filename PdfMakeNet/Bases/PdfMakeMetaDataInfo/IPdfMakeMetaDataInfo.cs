using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeMetaDataInfo
    {
        /// <summary>
        /// The title of the document
        /// </summary>
        [JsonProperty("title")]
        string Title { get; set; }
        /// <summary>
        /// The name of the author
        /// </summary>
        [JsonProperty("author")]
        string Author { get; set; }
        /// <summary>
        /// The subject of the document
        /// </summary>
        [JsonProperty("subject")]
        string Subject { get; set; }
        /// <summary>
        /// Keywords associated with the document
        /// </summary>
        [JsonProperty("keywords ")]
        string Keywords { get; set; }
        /// <summary>
        /// The creator of the document (default is ‘pdfmake’)
        /// </summary>
        [JsonProperty("creator")]
        string Creator { get; set; }
        /// <summary>
        /// The producer of the document (default is ‘pdfmake’)
        /// </summary>
        [JsonProperty("producer")]
        string Producer { get; set; }
        /// <summary>
        /// The date the document was created (added automatically by pdfmake)
        /// </summary>
        [JsonProperty("creationDate")]
        string CreationDate { get; set; }
        /// <summary>
        /// The date the document was last modified
        /// </summary>
        [JsonProperty("modDate")]
        string ModDate { get; set; }
        /// <summary>
        /// The trapped flag in a PDF document indicates whether the document has been “trapped”, i.e. corrected for slight color misregistrations
        /// </summary>
        [JsonProperty("trapped")]
        bool Trapped { get; set; }
    }
}
