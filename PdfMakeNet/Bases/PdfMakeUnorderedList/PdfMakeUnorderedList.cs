using Newtonsoft.Json;
using System.Collections.Generic;
using PdfMakeNet.Extensions;

namespace PdfMakeNet
{
    public class PdfMakeUnorderedList<T> : PdfMakeStyle, IPdfMakeStyle, IPdfMakeUnorderedList<T>
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ul")]
        public IList<T> Ul { get; set; }
        /// <summary>
        /// UnorderedListType option
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public UnorderedListType UnorderedListType { get; set; }
        /// <summary>
        /// Marker color
        /// </summary>
        [JsonProperty("markerColor")]
        public string MarkerColor { get; set; }
    }
}
