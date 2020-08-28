using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeTexts<T>: PdfMakeStyle, IPdfMakeStyle, IPdfMakeTexts<T>
    {
        /// <summary>
        /// Adds texts
        /// </summary>
        [JsonProperty("text")]
        public IList<T> Text { get; set; }
    }
}
