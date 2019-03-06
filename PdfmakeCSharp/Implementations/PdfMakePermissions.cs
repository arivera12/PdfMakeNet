using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakePermissions
    {
        [Key("printing")]
        public PrintingResolution Printing { get; set; }
        [Key("modifying")]
        public bool Modifying { get; set; }
        [Key("copying")]
        public bool Copying { get; set; }
        [Key("annotating")]
        public bool Annotating { get; set; }
        [Key("fillingForms")]
        public bool FillingForms { get; set; }
        [Key("contentAccessibility")]
        public bool ContentAccessibility { get; set; }
        [Key("documentAssembly")]
        public bool DocumentAssembly { get; set; }
    }
}
