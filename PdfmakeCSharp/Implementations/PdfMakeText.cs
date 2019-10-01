using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    public class PdfMakeText : PdfMakeStyle
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
