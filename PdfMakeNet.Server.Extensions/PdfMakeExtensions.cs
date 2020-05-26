using Microsoft.AspNetCore.Mvc;

namespace PdfMakeNet.Server.Extensions
{
    public static class PdfMakeExtensions
    {
        /// <summary>
        /// Sends a json result with the pdf document definition
        /// </summary>
        /// <returns></returns>
        public static IActionResult DocumentDefinitionInBrowser(this IPdfMake pdfMake)
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
        public static IActionResult DownloadInBrowser(this IPdfMake pdfMake, string Filename)
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
        public static IActionResult EmbedInBrowserIframe(this IPdfMake pdfMake, string IFrameQuerySelector)
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
        public static IActionResult OpenInBrowser(this IPdfMake pdfMake, bool SameWindow)
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
        public static IActionResult PrintInBrowser(this IPdfMake pdfMake, bool SameWindow)
        {
            return new ContentResult()
            {
                Content = pdfMake.GetPrintInBrowser(SameWindow),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }
    }
}
