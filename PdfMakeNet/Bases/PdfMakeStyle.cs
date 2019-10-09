using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeStyle
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
        /// font size option. Default 12.
        /// </summary>
        [JsonProperty("fontSize")]
        public int FontSize { get; set; } = 12;
        /// <summary>
        /// bold option
        /// </summary>
        [JsonProperty("bold")]
        public bool Bold { get; set; }
        /// <summary>
        /// italics style
        /// </summary>
        [JsonProperty("italics")]
        public bool Italics { get; set; }
        /// <summary>
        /// Color option
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
        /// <summary>
        /// margin option. Possible options: margin: [left, top, right, bottom] or [horizontal, vertical] or equalLeftTopRightBottom
        /// </summary>
        [JsonProperty("margin")]
        public object Margin { get; set; }
        /// <summary>
        /// Column gap option
        /// </summary>
        [JsonProperty("columnGap")]
        public int ColumnGap { get; set; }
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
        public double Opacity { get; set; }
        /// <summary>
        /// Fit option
        /// </summary>
        [JsonProperty("fit")]
        public List<int> Fit { get; set; }
        /// <summary>
        /// Table of content item option
        /// </summary>
        [JsonProperty("tocItem")]
        public object TocItem { get; set; }
        /// <summary>
        /// Page break option
        /// </summary>
        [JsonProperty("pageBreak")]
        public string PageBreak { get; set; }
        /// <summary>
        /// Alignment option
        /// </summary>
        [JsonProperty("alignment")]
        public string Alignment { get; set; }
        /// <summary>
        /// Page orientation option
        /// </summary>
        [JsonProperty("pageOrientation")]
        public string PageOrientation { get; set; }
        /// <summary>
        /// Style option
        /// </summary>
        [JsonProperty("style")]
        public List<string> Style { get; set; }
    }
}
