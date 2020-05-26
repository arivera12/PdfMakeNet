using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeWaterMark : PdfMakeText, IPdfMakeText, IPdfMakeWaterMark
    {
        /// <summary>
        /// Adds angle to the water mark
        /// </summary>
        [JsonProperty("angle")]
        public double? Angle { get; set; }
    }
}
