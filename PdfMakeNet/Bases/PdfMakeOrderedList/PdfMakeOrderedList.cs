using Newtonsoft.Json;
using PdfMakeNet.Extensions;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeOrderedList<T> : PdfMakeStyle, IPdfMakeStyle, IPdfMakeOrderedList<T>
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ol")]
        public IList<T> Ol { get; set; }

        /// <summary>
        /// Ordered list in decending order
        /// </summary>
        [JsonProperty("reversed")]
        public bool? Reversed { get; set; }

        /// <summary>
        /// Starting number for ordered list
        /// </summary>
        [JsonProperty("start")]
        public int? Start { get; set; }
        /// <summary>
        /// Marker color
        /// </summary>
        [JsonProperty("markerColor")]
        public string MarkerColor { get; set; }
        /// <summary>
        /// OrderedListType option
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public OrderedListType OrderedListType { get; set; }
        /// <summary>
        /// Separator string | [string, string]
        /// </summary>
        [JsonProperty("separator")]
        public object Separator { get; set; }
    }
}
