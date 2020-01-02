using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeColumns<T> : PdfMakeStyle
    {
        /// <summary>
        /// Lis of columns
        /// </summary>
        [JsonProperty("columns")]
        public IList<T> Columns { get; set; }
    }
}
