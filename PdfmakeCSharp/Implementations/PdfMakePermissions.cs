using Newtonsoft.Json;

namespace PdfMakeCSharp
{
    public class PdfMakePermissions
    {
        [JsonProperty("printing")]
        public string Printing { get; set; }
        [JsonProperty("modifying")]
        public bool Modifying { get; set; }
        [JsonProperty("copying")]
        public bool Copying { get; set; }
        [JsonProperty("annotating")]
        public bool Annotating { get; set; }
        [JsonProperty("fillingForms")]
        public bool FillingForms { get; set; }
        [JsonProperty("contentAccessibility")]
        public bool ContentAccessibility { get; set; }
        [JsonProperty("documentAssembly")]
        public bool DocumentAssembly { get; set; }
    }
}
