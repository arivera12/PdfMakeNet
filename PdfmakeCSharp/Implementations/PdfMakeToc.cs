using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeToc
    {
        [Key("id")]
        public string Id { get; set; }
        [Key("title")]
        public PdfMakeText Title { get; set; }
    }
}
