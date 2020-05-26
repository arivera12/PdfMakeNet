using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeSvg : IPdfMakeStyle
    {
        /// <summary>
        /// Adds svg
        /// </summary>
        [JsonProperty("svg")]
        string Svg { get; set; }
    }
}
