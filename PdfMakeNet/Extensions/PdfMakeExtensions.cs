using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PdfMakeNet
{
    public static class PdfMakeExtensions
    {
        /// <summary>
        /// Extension method to help you build tables more faster an easier without the hassle of loops and structure
        /// </summary>
        /// <param name="Columns"></param>
        /// <param name="Rows"></param>
        /// <returns></returns>
        public static List<object> AddTableBodyStructure(this PdfMake pdfMake, List<string> Columns, List<object> Rows)
        {
            var body = new List<object>
            {
                Columns
            };
            foreach (var items in Rows)
            {
                var values = new List<object>();
                var type = items.GetType();
                if (type.GetGenericArguments()[0].IsSimpleType() && !type.IsAnonymousType())
                {
                    foreach (var item in (dynamic)items)
                    {
                        values.Add(item);
                    }
                }
                else
                {
                    foreach (PropertyInfo prop in items.GetType().GetProperties())
                    {
                        values.Add(items.GetType().GetProperty(prop.Name).GetValue(items));
                    }
                }
                body.Add(values);
            }
            return body;
        }
        
        #region Client Side Content Result
        /// <summary>
        /// Sends a json result with the pdf document definition
        /// </summary>
        /// <returns></returns>
        public static ContentResult DocumentDefinitionInBrowser(this PdfMake pdfMake)
        {
            return new ContentResult()
            {
                Content = pdfMake.GetDocumentDefinition(),
                ContentType = "application/json",
                StatusCode = 200
            };
        }
        /// <summary>
        /// Sends a javascript script to download the pdf document in browser 
        /// </summary>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public static ContentResult DownloadInBrowser(this PdfMake pdfMake, string Filename)
        {
            return new ContentResult()
            {
                Content = pdfMake.GetDownloadInBrowser(Filename),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        /// <summary>
        /// Sends a javascript script with the specified Iframe selector to display the pdf document
        /// </summary>
        /// <param name="IFrameQuerySelector"></param>
        /// <returns></returns>
        public static ContentResult EmbedInBrowserIframe(this PdfMake pdfMake, string IFrameQuerySelector)
        {
            return new ContentResult()
            {
                Content = pdfMake.GetEmbedInBrowserIframe(IFrameQuerySelector),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        /// <summary>
        /// Sends a javascript script to open the pdf document in the browser
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public static ContentResult OpenInBrowser(this PdfMake pdfMake, bool SameWindow)
        {
            return new ContentResult()
            {
                Content = pdfMake.GetOpenInBrowser(SameWindow),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        /// <summary>
        /// Sends a javascript script to prompt the printer with the pdf document
        /// </summary>
        /// <param name="SameWindow"></param>
        /// <returns></returns>
        public static ContentResult PrintInBrowser(this PdfMake pdfMake, bool SameWindow)
        {
            return new ContentResult()
            {
                Content = pdfMake.GetPrintInBrowser(SameWindow),
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
        public static string GetDocumentDefinition(this PdfMake pdfMake)
        {
            return JsonConvert.SerializeObject(pdfMake);
        }

        /// <summary>
        /// Gets the javascript script to dowload the pdf document
        /// </summary>
        /// <param name="Filename"></param>
        /// <returns></returns>
        public static string GetDownloadInBrowser(this PdfMake pdfMake, string Filename)
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
        public static string GetEmbedInBrowserIframe(this PdfMake pdfMake, string IFrameQuerySelector)
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
        public static string GetOpenInBrowser(this PdfMake pdfMake, bool SameWindow)
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
        public static string GetPrintInBrowser(this PdfMake pdfMake, bool SameWindow)
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
        #endregion
    }
}
