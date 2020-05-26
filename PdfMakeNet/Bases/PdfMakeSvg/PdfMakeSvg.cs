using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeSvg : PdfMakeStyle, IPdfMakeStyle, IPdfMakeSvg
    {
        /// <summary>
        /// Adds text
        /// </summary>
        [JsonProperty("svg")]
        public string Svg { get; set; }
    }
}
