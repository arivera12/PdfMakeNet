using Newtonsoft.Json;
using PdfMakeNet.Extensions;

namespace PdfMakeNet
{
    /// <summary>
    /// Setup you pdf document permissions
    /// </summary>
    public class PdfMakePermissions
    {
        /// <summary>
        /// Whether printing is allowed. Specify "lowResolution" to allow degraded printing, or "highResolution" to allow printing with high resolution
        /// </summary>
        [JsonProperty("printing")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PrintingResolution Printing { get; set; }
        /// <summary>
        /// Whether modifying the file is allowed. Specify true to allow modifying document content
        /// </summary>
        [JsonProperty("modifying")]
        public bool Modifying { get; set; }
        /// <summary>
        /// Whether copying text or graphics is allowed. Specify true to allow copying
        /// </summary>
        [JsonProperty("copying")]
        public bool Copying { get; set; }
        /// <summary>
        /// Whether annotating, form filling is allowed. Specify true to allow annotating and form filling
        /// </summary>
        [JsonProperty("annotating")]
        public bool Annotating { get; set; }
        /// <summary>
        /// Whether form filling and signing is allowed. Specify true to allow filling in form fields and signing
        /// </summary>
        [JsonProperty("fillingForms")]
        public bool FillingForms { get; set; }
        /// <summary>
        /// Whether copying text for accessibility is allowed. Specify true to allow copying for accessibility
        /// </summary>
        [JsonProperty("contentAccessibility")]
        public bool ContentAccessibility { get; set; }
        /// <summary>
        /// Whether assembling document is allowed. Specify true to allow document assembly
        /// </summary>
        [JsonProperty("documentAssembly")]
        public bool DocumentAssembly { get; set; }
    }
}
