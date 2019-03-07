using Microsoft.AspNetCore.Mvc;
using System;

namespace PdfMakeCSharp
{
    public class PdfMake : PdfMakeBase, IPdfmake
    {
        #region Client Side Content Result
        public ContentResult DocumentDefinitionInBrowser()
        {
            return new ContentResult()
            {
                Content = GetDocumentDefinition(),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        public ContentResult DownloadInBrowser(string Filename)
        {
            return new ContentResult()
            {
                Content = GetDownloadInBrowser(Filename),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        public ContentResult EmbedInBrowserIframe(string IFrameQuerySelector)
        {
            return new ContentResult()
            {
                Content = GetEmbedInBrowserIframe(IFrameQuerySelector),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

        public ContentResult OpenInBrowser(bool SameWindow)
        {
            return new ContentResult()
            {
                Content = GetOpenInBrowser(SameWindow),
                ContentType = "application/javascript",
                StatusCode = 200
            };
        }

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
        public string GetDocumentDefinition()
        {
            return MessagePack.MessagePackSerializer.ToJson(this);
        }

        public string GetDownloadInBrowser(string Filename)
        {
            if (string.IsNullOrWhiteSpace(Filename))
                throw new ArgumentNullException("The Filename is null, empty or whitespace.");

            if (!Filename.EndsWith(".pdf"))
                throw new FormatException("The Filename does not end with .pdf extension.");

            return "pdfMake.createPdf(" + GetDocumentDefinition() + ").download(" + Filename + ");";
        }

        public string GetEmbedInBrowserIframe(string IFrameQuerySelector)
        {
            if (string.IsNullOrWhiteSpace(IFrameQuerySelector))
                throw new ArgumentNullException("The IframeQuerySelector is null, empty or whitespace.");

            return @"pdfMake.createPdf(" + GetDocumentDefinition() + @").getDataUrl(function(dataUrl) {
                        document.querySelector('" + IFrameQuerySelector + @"').src = dataUrl
                    });";
        }

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

        #region Server Side Rendering
        public string GetBase64Data()
        {
            throw new NotImplementedException();
        }

        public byte[] GetBlobData()
        {
            throw new NotImplementedException();
        }

        public uint[] GetBufferData()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
