using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    public class PdfMakeStyle
    {
        [JsonProperty("background")]
        public string BackgroundColor { get; set; }
        [JsonProperty("fillColor")]
        public string FillColor { get; set; }
        [JsonProperty("fontSize")]
        public int FontSize { get; set; } = 12;
        [JsonProperty("bold")]
        public bool Bold { get; set; }
        [JsonProperty("italics")]
        public bool Italics { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        //margin: [left, top, right, bottom] OR margin: [horizontal, vertical] OR margin: equalLeftTopRightBottom
        [JsonProperty("margin")]
        public object Margin { get; set; }
        [JsonProperty("columnGap")]
        public int ColumnGap { get; set; }
        [JsonProperty("width")]
        public object Width { get; set; }
        [JsonProperty("height")]
        public object Height { get; set; }
        [JsonProperty("opacity")]
        public double Opacity { get; set; }
        [JsonProperty("fit")]
        public List<int> Fit { get; set; }
        [JsonProperty("tocItem")]
        public object TocItem { get; set; }
        [JsonProperty("pageBreak")]
        public string PageBreak { get; set; }
        [JsonProperty("alignment")]
        public string Alignment { get; set; }
        [JsonProperty("pageOrientation")]
        public string PageOrientation { get; set; }
        [JsonProperty("style")]
        public List<string> Style { get; set; }
    }
}
