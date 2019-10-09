using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public abstract class PdfMake : IPdfmake<object>
    {
        #region Fields
        /// <summary>
        /// The header section
        /// </summary>
        [JsonProperty("header")]
        public List<object> Header { get; set; }
        /// <summary>
        /// The footer section
        /// </summary>
        [JsonProperty("footer")]
        public List<object> Footer { get; set; }
        /// <summary>
        /// The body section
        /// </summary>
        [JsonProperty("content")]
        public List<object> Body { get; set; }
        /// <summary>
        /// The background color section
        /// </summary>
        [JsonProperty("background")]
        public object Background { get; set; }
        /// <summary>
        /// The images section
        /// </summary>
        [JsonProperty("images")]
        public object Images { get; set; }
        /// <summary>
        /// The default style section
        /// </summary>
        [JsonProperty("defaultStyle")]
        public PdfMakeStyle DefaultStyle { get; set; }
        /// <summary>
        /// The style section
        /// </summary>
        [JsonProperty("styles")]
        public object Styles { get; set; }
        /// <summary>
        /// The page size option
        /// </summary>
        [JsonProperty("pageSize")]
        public string PageSize { get; set; }
        /// <summary>
        /// The page margins option
        /// </summary>
        [JsonProperty("pageMargins")]
        public List<int> PageMargins { get; set; }
        /// <summary>
        /// The page orientation option
        /// </summary>
        [JsonProperty("pageOrientation")]
        public string PageOrientation { get; set; }
        /// <summary>
        /// The compression option
        /// </summary>
        [JsonProperty("compress")]
        public bool Compress { get; set; }
        /// <summary>
        /// The user password option
        /// </summary>
        [JsonProperty("userPassword")]
        public string UserPassword { get; set; }
        /// <summary>
        /// The owner password option
        /// </summary>
        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; set; }
        /// <summary>
        /// The permissions section
        /// </summary>
        [JsonProperty("permissions")]
        public PdfMakePermissions Permissions { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public PdfMake()
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = PdfMakeNet.PageSize.LETTER;
        }
        #endregion

        #region Body
        /// <summary>
        /// Adds a qr code to the body section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddQRCode(PdfMakeQRCode qRCode)
        {
            Body.Add(qRCode);
        }
        /// <summary>
        /// Adds a text to the body section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddText(PdfMakeText PdfMakeText)
        {
            Body.Add(PdfMakeText);
        }
        /// <summary>
        /// Add a list of texts to the body section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        public void AddText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Body.Add(new { text = PdfMakeTexts });
        }
        /// <summary>
        /// Adds columns to the body section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddColumns(PdfMakeColumns<object> Columns)
        {
            Body.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the body section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddTable(PdfMakeTable<object> pdfMakeTable)
        {
            Body.Add(pdfMakeTable);
        }
        /// <summary>
        ///  Adds a ordered list to the body section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            Body.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered list to the body section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            Body.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the body section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddStack(PdfMakeStack<object> pdfMakeStacks)
        {
            Body.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the body section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddImage(PdfMakeImage pdfMakeImage)
        {
            Body.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds a link to the body section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddLink(PdfMakeLink pdfMakeLink)
        {
            Body.Add(pdfMakeLink);
        }
        /// <summary>
        /// Adds a table of content to the body section
        /// </summary>
        /// <param name="pdfMakeTableOfContent"></param>
        public void AddTableOfContent(PdfMakeTableOfContent pdfMakeTableOfContent)
        {
            Body.Add(pdfMakeTableOfContent);
        }
        #endregion

        #region Header
        /// <summary>
        /// Adds a qr code to the header section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddHeaderQRCode(PdfMakeQRCode qRCode)
        {
            Header.Add(qRCode);
        }
        /// <summary>
        /// Adds a text to the header section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddHeaderText(PdfMakeText PdfMakeText)
        {
            Header.Add(PdfMakeText);
        }
        /// <summary>
        /// Adds list of texts to the header section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddHeaderText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Header.Add(new { text = PdfMakeTexts });
        }
        /// <summary>
        ///  Adds text to the header section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddHeaderColumns(PdfMakeColumns<object> Columns)
        {
            Header.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the header section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddHeaderTable(PdfMakeTable<object> pdfMakeTable)
        {
            Header.Add(pdfMakeTable);
        }
        /// <summary>
        /// Adds a ordered list to the header section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddHeaderOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            Header.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered list to the header section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddHeaderUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            Header.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the header section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddHeaderStack(PdfMakeStack<object> pdfMakeStacks)
        {
            Header.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the header section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddHeaderImage(PdfMakeImage pdfMakeImage)
        {
            Header.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds a link to the header section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddHeaderLink(PdfMakeLink pdfMakeLink)
        {
            Header.Add(pdfMakeLink);
        }
        #endregion

        #region Footer
        /// <summary>
        /// Adds a qr code to the footer section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddFooterQRCode(PdfMakeQRCode qRCode)
        {
            Footer.Add(qRCode);
        }
        /// <summary>
        /// Adds a text to the footer section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddFooterText(PdfMakeText PdfMakeText)
        {
            Footer.Add(PdfMakeText);
        }
        /// <summary>
        /// Adds a list of texts to the footer section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        public void AddFooterText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Footer.Add(new { text = PdfMakeTexts });
        }
        /// <summary>
        /// Adds a columns to the footer section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddFooterColumns(PdfMakeColumns<object> Columns)
        {
            Footer.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the footer section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddFooterTable(PdfMakeTable<object> pdfMakeTable)
        {
            Footer.Add(pdfMakeTable);
        }
        /// <summary>
        /// Adds a ordered list to the footer section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddFooterOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            Footer.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered list to the footer section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddFooterUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            Footer.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the footer section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddFooterStack(PdfMakeStack<object> pdfMakeStacks)
        {
            Footer.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the footer section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddFooterImage(PdfMakeImage pdfMakeImage)
        {
            Footer.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds a link to the footer section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddFooterLink(PdfMakeLink pdfMakeLink)
        {
            Footer.Add(pdfMakeLink);
        }
        #endregion 
    }
}
