namespace PdfmakeCSharp
{
    public interface IStyle
    {
        int FontSize { get; set; }
        bool Bold { get; set; }
        bool Italics { get; set; }
        string Color { get; set; }
        int[] Margin { get; set; }
        int ColumnGap { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        double Opacity { get; set; }
        int[] Fit { get; set; }
        PageBreak PageBreak { get; set; }
        TextAlingment Alignment { get; set; }
    }
}
