using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeQRCode : PdfMakeStyle
    {
        [Key("qr")]
        public string Text { get; set; }
        [Key("foreground")]
        public string Foreground { get; set; }
        [Key("background")]
        public string Background { get; set; }
        [Key("version")]
        public Version Version { get; set; }
        [Key("eccLevel")]
        public string EccLevel { get; set; }
        [Key("mode")]
        public string Mode { get; set; }
        [Key("mask")]
        public Mask Mask { get; set; }
    }
}
