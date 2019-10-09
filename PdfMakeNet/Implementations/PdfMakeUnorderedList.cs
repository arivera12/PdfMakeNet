using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeUnorderedList<T> : PdfMakeStyle
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ul")]
        public List<T> Ul { get; set; }
    }
}
