using MessagePack;
using System.Collections.Generic;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeStack<T>
    {
        [Key("stack")]
        public List<T> Stack { get; set; }
    }
}
