using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakePermissions
    {
        [Key("printing")]
        public string Printing { get; set; }
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
