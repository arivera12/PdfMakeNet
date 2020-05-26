using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeWaterMark  : IPdfMakeText
    {
        /// <summary>
        /// Adds angle to the water mark
        /// </summary>
        [JsonProperty("angle")]
        double? Angle { get; set; }
    }
}
