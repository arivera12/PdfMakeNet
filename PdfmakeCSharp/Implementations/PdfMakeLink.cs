using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeLink : PdfMakeStyle
    {
        [Key("link")]
        public string Link { get; set; }
        [Key("linkToPage")]
        public int LinkToPage { get; set; }
    }
}
