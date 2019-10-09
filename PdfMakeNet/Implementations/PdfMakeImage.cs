using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeImage : PdfMakeStyle
    {
        /// <summary>
        /// Adds an image
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
