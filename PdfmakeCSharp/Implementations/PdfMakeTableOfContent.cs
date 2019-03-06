using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeTableOfContent
    {
        [Key("toc")]
        public PdfMakeToc Toc { get; set; }
    }
}
