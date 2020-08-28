using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeColumns<T> : PdfMakeStyle, IPdfMakeStyle, IPdfMakeColumns<T>
    {
        /// <summary>
        /// List of columns
        /// </summary>
        [JsonProperty("columns")]
        public IList<T> Columns { get; set; }
    }
}
