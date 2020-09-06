using Newtonsoft.Json;
using PdfMakeNet.Extensions;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeStyle : IPdfMakeStyle
    {
        /// <summary>
        /// background option
        /// </summary>
        [JsonProperty("background")]
        public string BackgroundColor { get; set; }
        /// <summary>
        /// fill color option
        /// </summary>
        [JsonProperty("fillColor")]
        public string FillColor { get; set; }
        /// <summary>
        /// font size option
        /// </summary>
        [JsonProperty("fontSize")]
        public int? FontSize { get; set; }
        /// <summary>
        /// bold option
        /// </summary>
        [JsonProperty("bold")]
        public bool? Bold { get; set; }
        /// <summary>
        /// italics style
        /// </summary>
        [JsonProperty("italics")]
        public bool? Italics { get; set; }
        /// <summary>
        /// Color option
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
        /// <summary>
        /// margin option. Possible options: margin: [left, top, right, bottom] or [horizontal, vertical] or one value equal LeftTopRightBottom
        /// </summary>
        [JsonProperty("margin")]
        public object Margin { get; set; }
        /// <summary>
        /// Column gap option
        /// </summary>
        [JsonProperty("columnGap")]
        public int? ColumnGap { get; set; }
        /// <summary>
        /// Width option
        /// </summary>
        [JsonProperty("width")]
        public object Width { get; set; }
        /// <summary>
        /// Height option
        /// </summary>
        [JsonProperty("height")]
        public object Height { get; set; }
        /// <summary>
        /// Opacity option
        /// </summary>
        [JsonProperty("opacity")]
        public double? Opacity { get; set; }
        /// <summary>
        /// Fit option
        /// </summary>
        [JsonProperty("fit")]
        public IList<int> Fit { get; set; }
        /// <summary>
        /// Table of content item option
        /// </summary>
        [JsonProperty("tocItem")]
        public object TocItem { get; set; }
        /// <summary>
        /// Page break option
        /// </summary>
        [JsonProperty("pageBreak")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PageBreak PageBreak { get; set; }
        /// <summary>
        /// Alignment option
        /// </summary>
        [JsonProperty("alignment")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public Alingment Alignment { get; set; }
        /// <summary>
        /// Page orientation option
        /// </summary>
        [JsonProperty("pageOrientation")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PageOrientation PageOrientation { get; set; }
        /// <summary>
        /// Style option
        /// </summary>
        [JsonProperty("style")]
        public IList<string> Style { get; set; }
        /// <summary>
        /// Colspan option
        /// </summary>
        [JsonProperty("colSpan")]
        public int ColSpan { get; set; }
        /// <summary>
        /// Rowspan option
        /// </summary>
        [JsonProperty("rowSpan")]
        public int RowSpan { get; set; }
        /// <summary>
        /// Border option
        /// </summary>
        [JsonProperty("border")]
        public IList<bool> Border { get; set; }
    }
}
