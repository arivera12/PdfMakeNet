using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PdfMakeNet
{
    public static class PdfMakeExtensions
    {
        /// <summary>
        /// Gets the document definition in json
        /// </summary>
        /// <returns></returns>
        public static string GetDocumentDefinition(this IPdfMake pdfMake, Formatting formatting = Formatting.None)
        {
            return JsonConvert.SerializeObject(pdfMake, formatting);
        }
        /// <summary>
        /// Gets the javascript script to dowload the pdf document
        /// </summary>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public static string GetDownloadInBrowser(this IPdfMake pdfMake, string Filename)
        {
            if (string.IsNullOrWhiteSpace(Filename))
                throw new ArgumentNullException("The Filename is null, empty or whitespace.");

            if (!Filename.EndsWith(".pdf"))
                throw new FormatException("The Filename does not end with .pdf extension.");

            return $"pdfMake.createPdf({pdfMake.GetDocumentDefinition()}).download({Filename});";
        }
        /// <summary>
        /// Gets the javascript script to display the pdf document in iframe
        /// </summary>
        /// <param name="IFrameQuerySelector"></param>
        /// <returns></returns>
        public static string GetEmbedInBrowserIframe(this IPdfMake pdfMake, string IFrameQuerySelector)
        {
            if (string.IsNullOrWhiteSpace(IFrameQuerySelector))
                throw new ArgumentNullException("The IframeQuerySelector is null, empty or whitespace.");

            return $@"pdfMake.createPdf({pdfMake.GetDocumentDefinition()}).getDataUrl(function(dataUrl) {{
                        document.querySelector('{IFrameQuerySelector }').src = dataUrl
                    }});";
        }
        /// <summary>
        /// Gets the javascript script to open in window
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public static string GetOpenInBrowser(this IPdfMake pdfMake, bool SameWindow)
        {
            if (SameWindow)
            {
                return $"pdfMake.createPdf({pdfMake.GetDocumentDefinition()}).open({{}}, window);";
            }
            else
            {
                return $"pdfMake.createPdf({pdfMake.GetDocumentDefinition()}).open({{}}, window.open('', '_blank'));";
            }
        }
        /// <summary>
        /// Gets the javascript script to prompt the printer with the pdf document
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public static string GetPrintInBrowser(this IPdfMake pdfMake, bool SameWindow)
        {
            if (SameWindow)
            {
                return $"pdfMake.createPdf({pdfMake.GetDocumentDefinition()}).print({{}}, window);";
            }
            else
            {
                return $"pdfMake.createPdf({pdfMake.GetDocumentDefinition()}).print({{}}, window.open('', '_blank'));";
            }
        }
    }
}
