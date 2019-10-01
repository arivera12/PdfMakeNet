using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    public class PdfMakeUnorderedList<T> : PdfMakeStyle
    {
        [JsonProperty("ul")]
        public List<T> Ul { get; set; }
    }
}
