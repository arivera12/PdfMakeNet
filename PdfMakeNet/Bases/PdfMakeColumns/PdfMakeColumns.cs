using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeColumns<T> : PdfMakeStyle, IPdfMakeStyle, IPdfMakeColumns<T>
    {
        /// <summary>
        /// Lis of columns
        /// </summary>
        [JsonProperty("columns")]
        public IList<T> Columns { get; set; }
    }
}
