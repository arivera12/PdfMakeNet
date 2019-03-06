using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeOrderedList<T> : PdfMakeStyle
    {
        [Key("ol")]
        public List<T> Ol { get; set; }
    }
}
