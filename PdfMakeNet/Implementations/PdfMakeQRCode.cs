using Newtonsoft.Json;
using PdfMakeNet.Extensions;

namespace PdfMakeNet
{
    public class PdfMakeQRCode : PdfMakeStyle
    {
        /// <summary>
        /// Adds a qr code text
        /// </summary>
        [JsonProperty("qr")]
        public string Text { get; set; }
        /// <summary>
        /// Adds foreground
        /// </summary>
        [JsonProperty("foreground")]
        public string Foreground { get; set; }
        /// <summary>
        /// Adds background
        /// </summary>
        [JsonProperty("background")]
        public string Background { get; set; }
        /// <summary>
        /// Add the version
        /// </summary>
        [JsonProperty("version")]
        public Version Version { get; set; }
        /// <summary>
        /// Add the Ecc Level
        /// </summary>
        [JsonProperty("eccLevel")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public EccLevel EccLevel { get; set; }
        /// <summary>
        /// Add the mode
        /// </summary>
        [JsonProperty("mode")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public Mode Mode { get; set; }
        /// <summary>
        /// Add the mask
        /// </summary>
        [JsonProperty("mask")]
        public Mask Mask { get; set; }
    }
}
