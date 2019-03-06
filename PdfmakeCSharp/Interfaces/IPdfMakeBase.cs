using System.Collections.Generic;

namespace PdfmakeCSharp
{
    public interface IPdfMakeBase<T>
    {
        #region Fields
        List<object> Header { get; set; }
        List<object> Footer { get; set; }
        List<object> Body { get; set; }
        T Background { get; set; }
        object Images { get; set; }
        object Styles { get; set; }
        PageSize PageSize { get; set; }
        List<int> PageMargins { get; set; }
        PageOrientation PageOrientation { get; set; }
        bool Compress { get; set; }
        string UserPassword { get; set; }
        string OwnerPassword { get; set; }
        PdfMakePermissions Permissions { get; set; }
        #endregion

        #region Body
        void AddPdfMakeText(PdfMakeText pdfMakeText);
        void AddPdfMakeText(IEnumerable<PdfMakeText> pdfMakeTexts);
        void AddQRCode(PdfMakeQRCode qRCode);
        void AddQRCode(IEnumerable<PdfMakeQRCode> qRCodes);
        void AddColumns(IEnumerable<PdfMakeColumns<T>> Columns);
        void AddTable(PdfMakeTable<T> pdfMakeTable);
        void AddOrderedList(PdfMakeOrderedList<T> pdfMakeOrderedList);
        void AddUnorderedList(PdfMakeUnorderedList<T> pdfMakeUnorderedList);
        void AddStack(IEnumerable<PdfMakeStack<T>> pdfMakeStacks);
        void AddImage(PdfMakeImage pdfMakeImage);
        void AddLink(PdfMakeLink pdfMakeLink);
        void AddTableOfContent(PdfMakeTableOfContent pdfMakeTableOfContent);
        #endregion

        #region Header
        void AddHeaderPdfMakeText(PdfMakeText pdfMakeText);
        void AddHeaderPdfMakeText(IEnumerable<PdfMakeText> pdfMakeTexts);
        void AddHeaderQRCode(PdfMakeQRCode qRCode);
        void AddHeaderQRCode(IEnumerable<PdfMakeQRCode> qRCodes);
        void AddHeaderColumns(IEnumerable<PdfMakeColumns<T>> Columns);
        void AddHeaderTable(PdfMakeTable<T> pdfMakeTable);
        void AddHeaderOrderedList(PdfMakeOrderedList<T> pdfMakeOrderedList);
        void AddHeaderUnorderedList(PdfMakeUnorderedList<T> pdfMakeUnorderedList);
        void AddHeaderStack(IEnumerable<PdfMakeStack<T>> pdfMakeStacks);
        void AddHeaderImage(PdfMakeImage pdfMakeImage);
        void AddHeaderLink(PdfMakeLink pdfMakeLink);
        #endregion

        #region Footer
        void AddFooterPdfMakeText(PdfMakeText pdfMakeText);
        void AddFooterPdfMakeText(IEnumerable<PdfMakeText> pdfMakeTexts);
        void AddFooterQRCode(PdfMakeQRCode qRCode);
        void AddFooterQRCode(IEnumerable<PdfMakeQRCode> qRCodes);
        void AddFooterColumns(IEnumerable<PdfMakeColumns<T>> Columns);
        void AddFooterTable(PdfMakeTable<T> pdfMakeTable);
        void AddFooterOrderedList(PdfMakeOrderedList<T> pdfMakeOrderedList);
        void AddFooterUnorderedList(PdfMakeUnorderedList<T> pdfMakeUnorderedList);
        void AddFooterStack(IEnumerable<PdfMakeStack<T>> pdfMakeStacks);
        void AddFooterImage(PdfMakeImage pdfMakeImage);
        void AddFooterLink(PdfMakeLink pdfMakeLink);
        #endregion
    }
}
