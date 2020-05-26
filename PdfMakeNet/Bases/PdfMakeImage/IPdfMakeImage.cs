using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeImage : IPdfMakeStyle
    {
        /// <summary>
        /// Adds an image
        /// </summary>
        [JsonProperty("image")]
        string Image { get; set; }
    }
}
