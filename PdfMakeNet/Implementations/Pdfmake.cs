using Microsoft.AspNetCore.Mvc;
using System;

namespace PdfMakeNet
{
    public class PdfMake : PdfMakeBase, IPdfmake
    {
        #region Client Side Content Result
        /// <summary>
        /// Sends a json result with the pdf document definition
        /// </summary>
        /// <returns></returns>
        public ContentResult DocumentDefinitionInBrowser()
        {
            return new ContentResult()
            {
                Content = GetDocumentDefinition(),
                ContentType = "application/json",
                StatusCode = 200
            };
        }
        /// <summary>
        /// Sends a javascript script to download the pdf document in browser 
        /// </summary>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public ContentResult DownloadInBrowser(string Filename)
        {
            return new ContentResult()
            {
                Content = GetDownloadInBrowser(Filename),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        /// <summary>
        /// Sends a javascript script with the specified Iframe selector to display the pdf document
        /// </summary>
        /// <param name="IFrameQuerySelector"></param>
        /// <returns></returns>
        public ContentResult EmbedInBrowserIframe(string IFrameQuerySelector)
        {
            return new ContentResult()
            {
                Content = GetEmbedInBrowserIframe(IFrameQuerySelector),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        /// <summary>
        /// Sends a javascript script to open the pdf document in the browser
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public ContentResult OpenInBrowser(bool SameWindow)
        {
            return new ContentResult()
            {
                Content = GetOpenInBrowser(SameWindow),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        /// <summary>
        /// Sends a javascript script to prompt the printer with the pdf document
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public ContentResult PrintInBrowser(bool SameWindow)
        {
            return new ContentResult()
            {
                Content = GetPrintInBrowser(SameWindow),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }
        #endregion

        #region String Document Definitions
        /// <summary>
        /// Gets the document definition in json
        /// </summary>
        /// <returns></returns>
        public string GetDocumentDefinition()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Gets the javascript script to dowload the pdf document
        /// </summary>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public string GetDownloadInBrowser(string Filename)
        {
            if (string.IsNullOrWhiteSpace(Filename))
                throw new ArgumentNullException("The Filename is null, empty or whitespace.");

            if (!Filename.EndsWith(".pdf"))
                throw new FormatException("The Filename does not end with .pdf extension.");

            return "pdfMake.createPdf(" + GetDocumentDefinition() + ").download(" + Filename + ");";
        }

        /// <summary>
        /// Gets the javascript script to display the pdf document in iframe
        /// </summary>
        /// <param name="IFrameQuerySelector"></param>
        /// <returns></returns>
        public string GetEmbedInBrowserIframe(string IFrameQuerySelector)
        {
            if (string.IsNullOrWhiteSpace(IFrameQuerySelector))
                throw new ArgumentNullException("The IframeQuerySelector is null, empty or whitespace.");

            return @"pdfMake.createPdf(" + GetDocumentDefinition() + @").getDataUrl(function(dataUrl) {
                        document.querySelector('" + IFrameQuerySelector + @"').src = dataUrl
                    });";
        }

        /// <summary>
        /// Gets the javascript script to open in window
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public string GetOpenInBrowser(bool SameWindow)
        {
            if (SameWindow)
            {
                return "pdfMake.createPdf(" + GetDocumentDefinition() + ").open({}, window);";
            }
            else
            {
                return "pdfMake.createPdf(" + GetDocumentDefinition() + ").open({}, window.open('', '_blank'));";
            }
        }

        /// <summary>
        /// Gets the javascript script to prompt the printer with the pdf document
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public string GetPrintInBrowser(bool SameWindow)
        {
            if (SameWindow)
            {
                return "pdfMake.createPdf(" + GetDocumentDefinition() + ").print({}, window);";
            }
            else
            {
                return "pdfMake.createPdf(" + GetDocumentDefinition() + ").print({}, window.open('', '_blank'));";
            }
        }
        #endregion
    }
}
