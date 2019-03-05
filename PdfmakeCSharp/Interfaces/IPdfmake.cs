using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp.Interfaces
{
    interface IPdfmake <T> : IBasePdfMake <T>
    {
        void Download();
        void Open();
        void Print();
    }
}
