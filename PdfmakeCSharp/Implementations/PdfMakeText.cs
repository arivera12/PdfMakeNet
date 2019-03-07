using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeText : PdfMakeStyle
    {
        [Key("text")]
        public string Text { get; set; }
        [Key("style")]
        public List<string> Style { get; set; }
    }
}
