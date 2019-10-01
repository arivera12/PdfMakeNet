using Newtonsoft.Json;

namespace PdfMakeCSharp
{
    public class PdfMakeQRCode : PdfMakeStyle
    {
        [JsonProperty("qr")]
        public string Text { get; set; }
        [JsonProperty("foreground")]
        public string Foreground { get; set; }
        [JsonProperty("background")]
        public string Background { get; set; }
        [JsonProperty("version")]
        public Version Version { get; set; }
        [JsonProperty("eccLevel")]
        public string EccLevel { get; set; }
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("mask")]
        public Mask Mask { get; set; }
    }
}
