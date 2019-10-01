using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    public class PdfMakeOrderedList<T> : PdfMakeStyle
    {
        [JsonProperty("ol")]
        public List<T> Ol { get; set; }
    }
}
