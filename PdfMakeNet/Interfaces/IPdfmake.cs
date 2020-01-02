using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfmake<T>
    {
        #region Fields
        IList<object> Header { get; set; }
        IList<object> Footer { get; set; }
        IList<object> Body { get; set; }
        T Background { get; set; }
        object Images { get; set; }
        object Styles { get; set; }
        PageSize PageSize { get; set; }
        IList<int> PageMargins { get; set; }
        PageOrientation PageOrientation { get; set; }
        bool Compress { get; set; }
        string UserPassword { get; set; }
        string OwnerPassword { get; set; }
        PdfMakePermissions Permissions { get; set; }
        #endregion

        #region Body
        void AddText(PdfMakeText pdfMakeText);
        void AddText(IEnumerable<PdfMakeText> pdfMakeTexts);
        void AddQRCode(PdfMakeQRCode qRCode);
        void AddColumns(PdfMakeColumns<T> Columns);
        void AddTable(PdfMakeTable<T> pdfMakeTable);
        void AddOrderedList(PdfMakeOrderedList<T> pdfMakeOrderedList);
        void AddUnorderedList(PdfMakeUnorderedList<T> pdfMakeUnorderedList);
        void AddStack(PdfMakeStack<T> pdfMakeStacks);
        void AddImage(PdfMakeImage pdfMakeImage);
        void AddLink(PdfMakeLink pdfMakeLink);
        void AddTableOfContent(PdfMakeTableOfContent pdfMakeTableOfContent);
        #endregion

        #region Header
        void AddHeaderText(PdfMakeText pdfMakeText);
        void AddHeaderText(IEnumerable<PdfMakeText> pdfMakeTexts);
        void AddHeaderQRCode(PdfMakeQRCode qRCode);
        void AddHeaderColumns(PdfMakeColumns<T> Columns);
        void AddHeaderTable(PdfMakeTable<T> pdfMakeTable);
        void AddHeaderOrderedList(PdfMakeOrderedList<T> pdfMakeOrderedList);
        void AddHeaderUnorderedList(PdfMakeUnorderedList<T> pdfMakeUnorderedList);
        void AddHeaderStack(PdfMakeStack<T> pdfMakeStacks);
        void AddHeaderImage(PdfMakeImage pdfMakeImage);
        void AddHeaderLink(PdfMakeLink pdfMakeLink);
        #endregion

        #region Footer
        void AddFooterText(PdfMakeText pdfMakeText);
        void AddFooterText(IEnumerable<PdfMakeText> pdfMakeTexts);
        void AddFooterQRCode(PdfMakeQRCode qRCode);
        void AddFooterColumns(PdfMakeColumns<T> Columns);
        void AddFooterTable(PdfMakeTable<T> pdfMakeTable);
        void AddFooterOrderedList(PdfMakeOrderedList<T> pdfMakeOrderedList);
        void AddFooterUnorderedList(PdfMakeUnorderedList<T> pdfMakeUnorderedList);
        void AddFooterStack(PdfMakeStack<T> pdfMakeStacks);
        void AddFooterImage(PdfMakeImage pdfMakeImage);
        void AddFooterLink(PdfMakeLink pdfMakeLink);
        #endregion
    }
}
