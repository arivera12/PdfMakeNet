using PdfmakeCSharp.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp
{
    public interface IQRCode
    {
        string Qr { get; set; }
        string Foreground { get; set; }
        string Background { get; set; }
        int Fit { get; set; }
        string Version { get; set; }
        EccLevel EccLevel { get; set; }
        Mode Mode { get; set; }
        string Mask { get; set; }
    }
}
