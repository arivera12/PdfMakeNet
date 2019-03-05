using System.Collections.Generic;

namespace PdfmakeCSharp.Interfaces
{
    public interface IText : IStyle
    {
        string Text { get; set; }
        IList<string> Style { get; set; }
    }
}
