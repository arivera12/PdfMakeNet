using Newtonsoft.Json;
using PdfMakeNet.Extensions;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public interface IPdfMake
    {
        /// <summary>
        /// The header section
        /// </summary>
        [JsonProperty("header")]
        IList<object> Header { get; set; }
        /// <summary>
        /// The footer section
        /// </summary>
        [JsonProperty("footer")]
        IList<object> Footer { get; set; }
        /// <summary>
        /// The body section
        /// </summary>
        [JsonProperty("content")]
        IList<object> Body { get; set; }
        /// <summary>
        /// The background color section
        /// </summary>
        [JsonProperty("background")]
        object Background { get; set; }
        /// <summary>
        /// The images section
        /// </summary>
        [JsonProperty("images")]
        object Images { get; set; }
        /// <summary>
        /// The default style section
        /// </summary>
        [JsonProperty("defaultStyle")]
        PdfMakeStyle DefaultStyle { get; set; }
        /// <summary>
        /// The style section
        /// </summary>
        [JsonProperty("styles")]
        object Styles { get; set; }
        /// <summary>
        /// The page size option
        /// </summary>
        [JsonProperty("pageSize")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        PageSize PageSize { get; set; }
        /// <summary>
        /// The page margins option
        /// </summary>
        [JsonProperty("pageMargins")]
        IList<int> PageMargins { get; set; }
        /// <summary>
        /// The page orientation option
        /// </summary>
        [JsonProperty("pageOrientation")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        PageOrientation PageOrientation { get; set; }
        /// <summary>
        /// The compression option
        /// </summary>
        [JsonProperty("compress")]
        bool Compress { get; set; }
        /// <summary>
        /// The user password option
        /// </summary>
        [JsonProperty("userPassword")]
        string UserPassword { get; set; }
        /// <summary>
        /// The owner password option
        /// </summary>
        [JsonProperty("ownerPassword")]
        string OwnerPassword { get; set; }
        /// <summary>
        /// The permissions section
        /// </summary>
        [JsonProperty("permissions")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        PdfMakePermissions Permissions { get; set; }
        /// <summary>
        /// Adds a qr code to the body section
        /// </summary>
        /// <param name="qRCode"></param>
        void AddBodyQRCode(IPdfMakeQRCode qRCode);
        /// <summary>
        /// Adds a text to the body section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        void AddBodyText(IPdfMakeText PdfMakeText);
        /// <summary>
        /// Add a IList of texts to the body section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        void AddBodyText(IEnumerable<IPdfMakeText> PdfMakeTexts);
        /// <summary>
        /// Adds columns to the body section
        /// </summary>
        /// <param name="Columns"></param>
        void AddBodyColumns<T>(IPdfMakeColumns<T> Columns);
        /// <summary>
        /// Adds a table to the body section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        void AddBodyTable<T>(IPdfMakeTable<T> pdfMakeTable);
        /// <summary>
        ///  Adds a ordered IList to the body section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        void AddBodyOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList);
        /// <summary>
        /// Adds a unordered IList to the body section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        void AddBodyUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList);
        /// <summary>
        /// Adds a stack to the body section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        void AddBodyStack<T>(IPdfMakeStack<T> pdfMakeStacks);
        /// <summary>
        /// Adds an image to the body section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        void AddBodyImage(IPdfMakeImage pdfMakeImage);
        /// <summary>
        /// Adds a link to the body section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        void AddBodyLink(IPdfMakeLink pdfMakeLink);
        /// <summary>
        /// Adds a table of content to the body section
        /// </summary>
        /// <param name="pdfMakeTableOfContent"></param>
        void AddTableOfContent(IPdfMakeTableOfContent pdfMakeTableOfContent);
        /// <summary>
        /// Adds a qr code to the header section
        /// </summary>
        /// <param name="qRCode"></param>
        void AddHeaderQRCode(IPdfMakeQRCode qRCode);
        /// <summary>
        /// Adds a text to the header section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        void AddHeaderText(IPdfMakeText PdfMakeText);
        /// <summary>
        /// Adds IList of texts to the header section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        void AddHeaderText(IEnumerable<IPdfMakeText> PdfMakeTexts);
        /// <summary>
        ///  Adds text to the header section
        /// </summary>
        /// <param name="Columns"></param>
        void AddHeaderColumns<T>(IPdfMakeColumns<T> Columns);
        /// <summary>
        /// Adds a table to the header section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        void AddHeaderTable<T>(IPdfMakeTable<T> pdfMakeTable);
        /// <summary>
        /// Adds a ordered IList to the header section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        void AddHeaderOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList);
        /// <summary>
        /// Adds a unordered IList to the header section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        void AddHeaderUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList);
        /// <summary>
        /// Adds a stack to the header section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        void AddHeaderStack<T>(IPdfMakeStack<T> pdfMakeStacks);
        /// <summary>
        /// Adds an image to the header section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        void AddHeaderImage(IPdfMakeImage pdfMakeImage);
        /// <summary>
        /// Adds a link to the header section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        void AddHeaderLink(IPdfMakeLink pdfMakeLink);
        /// <summary>
        /// Adds a qr code to the footer section
        /// </summary>
        /// <param name="qRCode"></param>
        void AddFooterQRCode(IPdfMakeQRCode qRCode);
        /// <summary>
        /// Adds a text to the footer section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        void AddFooterText(IPdfMakeText PdfMakeText);
        /// <summary>
        /// Adds a IList of texts to the footer section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        void AddFooterText(IEnumerable<IPdfMakeText> PdfMakeTexts);
        /// <summary>
        /// Adds a columns to the footer section
        /// </summary>
        /// <param name="Columns"></param>
        void AddFooterColumns<T>(IPdfMakeColumns<T> Columns);
        /// <summary>
        /// Adds a table to the footer section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        void AddFooterTable<T>(IPdfMakeTable<T> pdfMakeTable);
        /// <summary>
        /// Adds a ordered IList to the footer section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        void AddFooterOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList);
        /// <summary>
        /// Adds a unordered IList to the footer section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        void AddFooterUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList);
        /// <summary>
        /// Adds a stack to the footer section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        void AddFooterStack<T>(IPdfMakeStack<T> pdfMakeStacks);
        /// <summary>
        /// Adds an image to the footer section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        void AddFooterImage(IPdfMakeImage pdfMakeImage);
        /// <summary>
        /// Adds a link to the footer section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        void AddFooterLink(IPdfMakeLink pdfMakeLink);
    }
}
