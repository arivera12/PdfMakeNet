using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    public class PdfMakeStack<T>
    {
        [JsonProperty("stack")]
        public List<T> Stack { get; set; }
    }
}
