using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeStack<T>: IPdfMakeStyle
    {
        /// <summary>
        /// Adds a stack
        /// </summary>
        [JsonProperty("stack")]
        IList<T> Stack { get; set; }
    }
}
