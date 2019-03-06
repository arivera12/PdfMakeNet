using MessagePack;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeImage : PdfMakeStyle
    {
        [Key("image")]
        public string Image { get; set; }
    }
}
