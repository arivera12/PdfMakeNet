using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeOrderedList<T> : IPdfMakeStyle
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ol")]
        IList<T> Ol { get; set; }
    }
}
