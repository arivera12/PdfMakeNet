using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeOrderedList<T> : PdfMakeStyle
    {
        /// <summary>
        /// Add unorderes list
        /// </summary>
        [JsonProperty("ol")]
        public List<T> Ol { get; set; }
    }
}
