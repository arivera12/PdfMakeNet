using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp.Interfaces
{
    interface IBasePdfMake <T>
    {
        List<T> content { get; set; }
        object styles { get; set; }
        void AddText(IText Text);
        void AddText(IList<IText> TextList);
    }
}
