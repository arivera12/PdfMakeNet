using Newtonsoft.Json;
using PdfMakeNet.Extensions;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMakeStyle
    {
        /// <summary>
        /// background option
        /// </summary>
        [JsonProperty("background")]
        string BackgroundColor { get; set; }
        /// <summary>
        /// fill color option
        /// </summary>
        [JsonProperty("fillColor")]
        string FillColor { get; set; }
        /// <summary>
        /// font size option. Default 12.
        /// </summary>
        [JsonProperty("fontSize")]
        int? FontSize { get; set; }
        /// <summary>
        /// bold option
        /// </summary>
        [JsonProperty("bold")]
        bool? Bold { get; set; }
        /// <summary>
        /// italics style
        /// </summary>
        [JsonProperty("italics")]
        bool? Italics { get; set; }
        /// <summary>
        /// Color option
        /// </summary>
        [JsonProperty("color")]
        string Color { get; set; }
        /// <summary>
        /// margin option. Possible options: margin: [left, top, right, bottom] or [horizontal, vertical] or one value equal LeftTopRightBottom
        /// </summary>
        [JsonProperty("margin")]
        object Margin { get; set; }
        /// <summary>
        /// Column gap option
        /// </summary>
        [JsonProperty("columnGap")]
        int? ColumnGap { get; set; }
        /// <summary>
        /// Width option
        /// </summary>
        [JsonProperty("width")]
        object Width { get; set; }
        /// <summary>
        /// Height option
        /// </summary>
        [JsonProperty("height")]
        object Height { get; set; }
        /// <summary>
        /// Opacity option
        /// </summary>
        [JsonProperty("opacity")]
        double? Opacity { get; set; }
        /// <summary>
        /// Fit option
        /// </summary>
        [JsonProperty("fit")]
        IList<int> Fit { get; set; }
        /// <summary>
        /// Table of content item option
        /// </summary>
        [JsonProperty("tocItem")]
        object TocItem { get; set; }
        /// <summary>
        /// Page break option
        /// </summary>
        [JsonProperty("pageBreak")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        PageBreak PageBreak { get; set; }
        /// <summary>
        /// Alignment option
        /// </summary>
        [JsonProperty("alignment")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        Alingment Alignment { get; set; }
        /// <summary>
        /// Page orientation option
        /// </summary>
        [JsonProperty("pageOrientation")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        PageOrientation PageOrientation { get; set; }
        /// <summary>
        /// Style option
        /// </summary>
        [JsonProperty("style")]
        IList<string> Style { get; set; }
        /// <summary>
        /// Colspan option
        /// </summary>
        [JsonProperty("colSpan")]
        int ColSpan { get; set; }
        /// <summary>
        /// Rowspan option
        /// </summary>
        [JsonProperty("rowSpan")]
        int RowSpan { get; set; }
        /// <summary>
        /// Border option
        /// </summary>
        [JsonProperty("border")]
        IList<bool> Border { get; set; }
    }
}
