using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeText : IPdfMakeStyle
    {
        /// <summary>
        /// Adds text
        /// </summary>
        [JsonProperty("text")]
        string Text { get; set; }
    }
}
