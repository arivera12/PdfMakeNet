using MessagePack;
using System.Collections.Generic;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeColumns<T> : PdfMakeStyle
    {
        [Key("columns")]
        public List<T> Columns { get; set; }
    }
}
