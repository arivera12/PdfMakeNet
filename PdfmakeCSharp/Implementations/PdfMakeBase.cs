using MessagePack;
using System.Collections.Generic;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    class PdfMakeBase : IPdfMakeBase<object>
    {
        #region Fields
        [Key("header")]
        public List<object> Header { get; set; }
        [Key("footer")]
        public List<object> Footer { get; set; }
        [Key("content")]
        public List<object> Body { get; set; }
        [Key("background")]
        public object Background { get; set; }
        [Key("images")]
        public object Images { get; set; }
        [Key("styles")]
        public object Styles { get; set; }
        [Key("pageSize")]
        public PageSize PageSize { get; set; }
        [Key("pageMargins")]
        public List<int> PageMargins { get; set; }
        [Key("pageOrientation")]
        public PageOrientation PageOrientation { get; set; }
        [Key("compress")]
        public bool Compress { get; set; }
        [Key("userPassword")]
        public string UserPassword { get; set; }
        [Key("ownerPassword")]
        public string OwnerPassword { get; set; }
        [Key("permissions")]
        public PdfMakePermissions Permissions { get; set; }
        #endregion

        #region Body
        public void AddQRCode(PdfMakeQRCode qRCode)
        {
            Body.Add(qRCode);
        }

        public void AddQRCode(IEnumerable<PdfMakeQRCode> qRCodes)
        {
            foreach (var item in qRCodes)
            {
                Body.Add(item);
            }
        }

        public void AddPdfMakeText(PdfMakeText PdfMakeText)
        {
            Body.Add(PdfMakeText);
        }

        public void AddPdfMakeText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Body.Add(new { PdfMakeTexts });
        }

        public void AddColumns(IEnumerable<PdfMakeColumns<object>> Columns)
        {
            Body.Add(Columns);
        }

        public void AddTable(PdfMakeTable<object> pdfMakeTable)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            throw new System.NotImplementedException();
        }

        public void AddUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            throw new System.NotImplementedException();
        }

        public void AddStack(IEnumerable<PdfMakeStack<object>> pdfMakeStacks)
        {
            throw new System.NotImplementedException();
        }

        public void AddImage(PdfMakeImage pdfMakeImage)
        {
            throw new System.NotImplementedException();
        }

        public void AddLink(PdfMakeLink pdfMakeLink)
        {
            throw new System.NotImplementedException();
        }

        public void AddTableOfContent(PdfMakeTableOfContent pdfMakeTableOfContent)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Header
        public void AddHeaderQRCode(PdfMakeQRCode qRCode)
        {
            Header.Add(qRCode);
        }

        public void AddHeaderQRCode(IEnumerable<PdfMakeQRCode> qRCodes)
        {
            foreach (var item in qRCodes)
            {
                Header.Add(item);
            }
        }

        public void AddHeaderPdfMakeText(PdfMakeText PdfMakeText)
        {
            Header.Add(PdfMakeText);
        }

        public void AddHeaderPdfMakeText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Header.Add(new { PdfMakeTexts });
        }

        public void AddHeaderColumns(IEnumerable<PdfMakeColumns<object>> Columns)
        {
            Header.Add(Columns);
        }

        public void AddHeaderTable(PdfMakeTable<object> pdfMakeTable)
        {
            throw new System.NotImplementedException();
        }

        public void AddHeaderOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            throw new System.NotImplementedException();
        }

        public void AddHeaderUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            throw new System.NotImplementedException();
        }

        public void AddHeaderStack(IEnumerable<PdfMakeStack<object>> pdfMakeStacks)
        {
            throw new System.NotImplementedException();
        }

        public void AddHeaderImage(PdfMakeImage pdfMakeImage)
        {
            throw new System.NotImplementedException();
        }

        public void AddHeaderLink(PdfMakeLink pdfMakeLink)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Footer
        public void AddFooterQRCode(PdfMakeQRCode qRCode)
        {
            Footer.Add(qRCode);
        }

        public void AddFooterQRCode(IEnumerable<PdfMakeQRCode> qRCodes)
        {
            foreach (var item in qRCodes)
            {
                Footer.Add(item);
            }
        }

        public void AddFooterPdfMakeText(PdfMakeText PdfMakeText)
        {
            Footer.Add(PdfMakeText);
        }

        public void AddFooterPdfMakeText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Footer.Add(new { PdfMakeTexts });
        }

        public void AddFooterColumns(IEnumerable<PdfMakeColumns<object>> Columns)
        {
            Footer.Add(Columns);
        }

        public void AddFooterTable(PdfMakeTable<object> pdfMakeTable)
        {
            throw new System.NotImplementedException();
        }

        public void AddFooterOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            throw new System.NotImplementedException();
        }

        public void AddFooterUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            throw new System.NotImplementedException();
        }

        public void AddFooterStack(IEnumerable<PdfMakeStack<object>> pdfMakeStacks)
        {
            throw new System.NotImplementedException();
        }

        public void AddFooterImage(PdfMakeImage pdfMakeImage)
        {
            throw new System.NotImplementedException();
        }

        public void AddFooterLink(PdfMakeLink pdfMakeLink)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
