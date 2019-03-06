using MessagePack;
using System.Collections.Generic;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeOrderedList<T> : PdfMakeStyle
    {
        [Key("ol")]
        public List<T> Ol { get; set; }
    }
}
