using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp.Interfaces
{
    interface IText : IStyle
    {
        string text { get; set; }
        IList<string> style { get; set; }
    }
}
