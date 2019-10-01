using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    public class PdfMakeColumns<T> : PdfMakeStyle
    {
        [JsonProperty("columns")]
        public List<T> Columns { get; set; }
    }
}
