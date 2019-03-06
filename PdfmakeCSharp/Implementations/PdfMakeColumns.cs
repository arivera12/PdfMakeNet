using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeColumns<T> : PdfMakeStyle
    {
        [Key("columns")]
        public List<T> Columns { get; set; }
    }
}
