using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeTableBody<T>
    {
        [Key("headerRows")]
        public int HeaderRows { get; set; }
        [Key("widths")]
        public List<string> Widths { get; set; }
        [Key("body")]
        public List<T> Body { get; set; }
    }
}
