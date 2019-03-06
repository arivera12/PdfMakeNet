using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeImage : PdfMakeStyle
    {
        [Key("image")]
        public string Image { get; set; }
    }
}
