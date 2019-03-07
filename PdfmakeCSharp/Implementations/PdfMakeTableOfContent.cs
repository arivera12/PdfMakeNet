using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeTableOfContent
    {
        [Key("toc")]
        public PdfMakeToc Toc { get; set; }
    }
}
