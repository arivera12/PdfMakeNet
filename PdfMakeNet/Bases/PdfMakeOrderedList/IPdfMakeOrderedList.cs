using Newtonsoft.Json;
using PdfMakeNet.Extensions;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeOrderedList<T> : IPdfMakeStyle
    {
        /// <summary>
        /// Add ordered list
        /// </summary>
        [JsonProperty("ol")]
        IList<T> Ol { get; set; }

        /// <summary>
        /// Ordered list in decending order
        /// </summary>
        [JsonProperty("reversed")]
        bool? Reversed { get; set; }

        /// <summary>
        /// Starting number for ordered list
        /// </summary>
        [JsonProperty("start")]
        int? Start { get; set; }
        /// <summary>
        /// Marker color
        /// </summary>
        [JsonProperty("markerColor")]
        string MarkerColor { get; set; }
        /// <summary>
        /// OrderedListType option
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        OrderedListType OrderedListType { get; set; }
        /// <summary>
        /// Separator string | [string, string]
        /// </summary>
        [JsonProperty("separator")]
        object Separator { get; set; }
    }
}
