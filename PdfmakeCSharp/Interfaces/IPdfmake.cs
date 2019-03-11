using Microsoft.AspNetCore.Mvc;
using System;

namespace PdfMakeCSharp
{
    public interface IPdfmake
    {
        #region Client Side Content Result
        ContentResult DownloadInBrowser(string Filename);
        ContentResult OpenInBrowser(bool SameWindow);
        ContentResult PrintInBrowser(bool SameWindow);
        ContentResult EmbedInBrowserIframe(string IFrameQuerySelector);
        ContentResult DocumentDefinitionInBrowser();
        ContentResult DocumentDataUrlInBrowser();
        #endregion
        #region String Document Definitions
        string GetDownloadInBrowser(string Filename);
        string GetOpenInBrowser(bool SameWindow);
        string GetPrintInBrowser(bool SameWindow);
        string GetEmbedInBrowserIframe(string IFrameQuerySelector);
        string GetDocumentDefinition();
        #endregion
        #region Server Side Rendering
        string GetBase64Data();
        uint[] GetBufferData();
        byte[] GetBlobData();
        string GetUrlData();
        void WriteToDisk(string path);
        #endregion
    }
}
