using MessagePack;
using System.Collections.Generic;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeUnorderedList<T> : PdfMakeStyle
    {
        [Key("ul")]
        public List<T> Ul { get; set; }
    }
}
