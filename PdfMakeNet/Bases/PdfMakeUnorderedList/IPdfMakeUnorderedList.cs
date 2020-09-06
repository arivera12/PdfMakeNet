using Newtonsoft.Json;
using System.Collections.Generic;
using PdfMakeNet.Extensions;

namespace PdfMakeNet
{
    public interface IPdfMakeUnorderedList<T> : IPdfMakeStyle
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ul")]
        IList<T> Ul { get; set; }
        /// <summary>
        /// UnorderedListType option
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        UnorderedListType UnorderedListType { get; set; }
        /// <summary>
        /// Marker color
        /// </summary>
        [JsonProperty("markerColor")]
        string MarkerColor { get; set; }
    }
}
