using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp.Interfaces
{
    interface IStyle
    {
        int fontSize { get; set; }
        bool bold { get; set; }
        bool italics { get; set; }
        string alignment { get; set; }
    }
}
