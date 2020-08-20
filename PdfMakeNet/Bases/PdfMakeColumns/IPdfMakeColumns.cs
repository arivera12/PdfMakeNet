using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeColumns<T> : IPdfMakeStyle
    {
        /// <summary>
        /// List of columns
        /// </summary>
        [JsonProperty("columns")]
        IList<T> Columns { get; set; }
    }
}
