using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeStack<T>
    {
        [Key("stack")]
        public List<T> Stack { get; set; }
    }
}
