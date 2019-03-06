using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeUnorderedList<T> : PdfMakeStyle
    {
        [Key("ul")]
        public List<T> Ul { get; set; }
    }
}
