using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeOrderedList<T> : PdfMakeStyle, IPdfMakeStyle, IPdfMakeOrderedList<T>
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ol")]
        public IList<T> Ol { get; set; }
    }
}
