using Newtonsoft.Json;
using PdfMakeNet.Extensions;

namespace PdfMakeNet
{
    public interface IPdfMakeQRCode : IPdfMakeStyle
    {
        /// <summary>
        /// Adds a qr code text
        /// </summary>
        [JsonProperty("qr")]
        string Text { get; set; }
        /// <summary>
        /// Adds foreground
        /// </summary>
        [JsonProperty("foreground")]
        string Foreground { get; set; }
        /// <summary>
        /// Adds background
        /// </summary>
        [JsonProperty("background")]
        string Background { get; set; }
        /// <summary>
        /// Add the version
        /// </summary>
        [JsonProperty("version")]
        Version Version { get; set; }
        /// <summary>
        /// Add the Ecc Level
        /// </summary>
        [JsonProperty("eccLevel")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        EccLevel EccLevel { get; set; }
        /// <summary>
        /// Add the mode
        /// </summary>
        [JsonProperty("mode")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        Mode Mode { get; set; }
        /// <summary>
        /// Add the mask
        /// </summary>
        [JsonProperty("mask")]
        Mask Mask { get; set; }
    }
}
