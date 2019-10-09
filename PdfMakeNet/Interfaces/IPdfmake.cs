using Microsoft.AspNetCore.Mvc;

namespace PdfMakeNet
{
    public interface IPdfmake
    {
        #region Client Side Content Result
        ContentResult DownloadInBrowser(string Filename);
        ContentResult OpenInBrowser(bool SameWindow);
        ContentResult PrintInBrowser(bool SameWindow);
        ContentResult EmbedInBrowserIframe(string IFrameQuerySelector);
        ContentResult DocumentDefinitionInBrowser();
        #endregion
       
        #region String Document Definitions
        string GetDownloadInBrowser(string Filename);
        string GetOpenInBrowser(bool SameWindow);
        string GetPrintInBrowser(bool SameWindow);
        string GetEmbedInBrowserIframe(string IFrameQuerySelector);
        string GetDocumentDefinition();
        #endregion
    }
}
