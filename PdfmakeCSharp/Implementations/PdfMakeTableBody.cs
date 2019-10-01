using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    public class PdfMakeTableBody<T>
    {
        [JsonProperty("headerRows")]
        public int HeaderRows { get; set; }
        [JsonProperty("widths")]
        public List<string> Widths { get; set; }
        [JsonProperty("body")]
        public List<T> Body { get; set; }
    }
}
