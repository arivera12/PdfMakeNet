using System.Collections.Generic;

namespace PdfmakeCSharp.Interfaces
{
    public interface IBasePdfMake<T>
    {
        List<T> Content { get; set; }
        object Styles { get; set; }
        void AddText(IText Text);
        void AddText(IList<IText> TextList);
    }
}
