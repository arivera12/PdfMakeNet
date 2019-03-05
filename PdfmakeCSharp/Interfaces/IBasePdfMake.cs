using System.Collections.Generic;

namespace PdfmakeCSharp
{
    /// <summary>
    /// Base class for pdfmake document structure
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBasePdfMake<T>
    {
        /// <summary>
        /// Document header content
        /// </summary>
        List<T> Header { get; set; }
        /// <summary>
        /// Document footer content
        /// </summary>
        List<T> Footer { get; set; }
        /// <summary>
        /// Document body content
        /// </summary>
        List<T> Body { get; set; }
        /// <summary>
        ///  Document Style Definitions
        /// </summary>
        object Styles { get; set; }



        /// <summary>
        /// Adds text to the body
        /// </summary>
        /// <param name="text"></param>
        void AddText(IText text);
        /// <summary>
        /// Adds a collection of texts to the body
        /// </summary>
        /// <param name="texts"></param>
        void AddText(IList<IText> texts);
        /// <summary>
        /// Adds a QRcode to the body
        /// </summary>
        /// <param name="qRCode"></param>
        void AddQRCode(IQRCode qRCode);
        /// <summary>
        /// Adds a collection of QRCodes to the body
        /// </summary>
        /// <param name="qRCodes"></param>
        void AddQRCode(IList<IQRCode> qRCodes);
        /// <summary>
        /// Adds text to the Header
        /// </summary>
        /// <param name="text"></param>
        void AddHeaderText(IText text);
        /// <summary>
        /// Adds a collection of texts to the Header
        /// </summary>
        /// <param name="text"></param>
        void AddHeaderText(IList<IText> text);
        /// <summary>
        /// Adds a QRcode to the body
        /// </summary>
        /// <param name="qRCode"></param>
        void AddHeaderQRCode(IQRCode qRCode);
        /// <summary>
        /// Adds a collection of QRCodes to the Header
        /// </summary>
        /// <param name="qRCode"></param>
        void AddHeaderQRCode(IList<IQRCode> qRCode);
        /// <summary>
        /// Adds text to the Footer
        /// </summary>
        /// <param name="text"></param>
        /// 
        void AddFooterText(IText text);
        /// <summary>
        /// Adds a collection of texts to the Footer
        /// </summary>
        /// <param name="text"></param>
        void AddFooterText(IList<IText> text);
        /// <summary>
        /// Adds a QRcode to the Footer
        /// </summary>
        /// <param name="qRCode"></param>
        void AddFooterQRCode(IQRCode qRCode);
        /// <summary>
        /// Adds a collection of texts to the Footer
        /// </summary>
        /// <param name="qRCode"></param>
        void AddFooterQRCode(IList<IQRCode> qRCode);

    }
}
