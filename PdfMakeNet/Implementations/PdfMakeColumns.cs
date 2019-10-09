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
        public List<T> Columns { get; set; }
    }
}
