using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeUnorderedList<T> : IPdfMakeStyle
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ul")]
        IList<T> Ul { get; set; }
    }
}
