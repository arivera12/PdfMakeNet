using MessagePack;
using System.Collections.Generic;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeText : PdfMakeStyle
    {
        [Key("text")]
        public string Text { get; set; }
        [Key("style")]
        public IList<string> Style { get; set; }
    }
}
