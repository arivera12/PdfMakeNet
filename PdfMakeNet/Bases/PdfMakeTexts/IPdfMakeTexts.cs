using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeTexts<T>: IPdfMakeStyle
    {
        /// <summary>
        /// Adds texts
        /// </summary>
        [JsonProperty("text")]
        IList<T> Text { get; set; }
    }
}
