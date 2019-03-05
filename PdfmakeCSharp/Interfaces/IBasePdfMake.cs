using System.Collections.Generic;

namespace PdfmakeCSharp.Interfaces
{
    public interface IBasePdfMake<T>
    {
        List<T> Content { get; set; }
        object Styles { get; set; }
        void AddText(IText text);
        void AddText(IList<IText> texts);
        void AddQRCode(IQRCode qRCode);
        void AddQRCode(IList<IQRCode> qRCodes);
    }
}
