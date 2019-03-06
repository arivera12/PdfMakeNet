using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public abstract class PdfMakeStyle
    {
        [Key("fontSize")]
        protected int FontSize { get; set; }
        [Key("bold")]
        protected bool Bold { get; set; }
        [Key("italics")]
        protected bool Italics { get; set; }
        [Key("Color")]
        protected string Color { get; set; }
        //margin: [left, top, right, bottom] OR margin: [horizontal, vertical] OR margin: equalLeftTopRightBottom
        [Key("margin")]
        protected object Margin { get; set; }
        [Key("columnGap")]
        protected int ColumnGap { get; set; }
        [Key("width")]
        protected int Width { get; set; }
        [Key("height")]
        protected int Height { get; set; }
        [Key("opacity")]
        protected double Opacity { get; set; }
        [Key("fit")]
        protected List<int> Fit { get; set; }
        [Key("tocItem")]
        public object TocItem { get; set; }
        [Key("pageBreak")]
        protected PageBreak PageBreak { get; set; }
        [Key("alignment")]
        protected TextAlingment Alignment { get; set; }
        [Key("pageOrientation")]
        protected PageOrientation PageOrientation { get; set; }

    }
}
