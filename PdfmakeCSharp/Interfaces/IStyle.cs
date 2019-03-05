using PdfmakeCSharp.Structs;

namespace PdfmakeCSharp.Interfaces
{
    public interface IStyle
    {
        int FontSize { get; set; }
        bool Bold { get; set; }
        bool Italics { get; set; }
        TextAlingment Alignment { get; set; }
    }
}
