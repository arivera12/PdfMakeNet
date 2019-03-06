using MessagePack;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeQRCode : PdfMakeStyle
    {
        [Key("qr")]
        public string Qr { get; set; }
        [Key("foreground")]
        public string Foreground { get; set; }
        [Key("background")]
        public string Background { get; set; }
        [Key("version")]
        public string Version { get; set; }
        [Key("eccLevel")]
        public EccLevel EccLevel { get; set; }
        [Key("mode")]
        public Mode Mode { get; set; }
        [Key("mask")]
        public string Mask { get; set; }
    }
}
