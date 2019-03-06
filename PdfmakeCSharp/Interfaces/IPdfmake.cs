using Microsoft.AspNetCore.Mvc;
using System;

namespace PdfMakeCSharp
{
    public interface IPdfmake
    {
        ContentResult DownloadInBrowser(string Filename);
        ContentResult OpenInBrowser(bool SameWindow);
        ContentResult PrintInBrowser(bool SameWindow);
        ContentResult EmbedInBrowserIframe(string IFrameQuerySelector);
        ContentResult DocumentDefinitionInBrowser();
        string GetDownloadInBrowser(string Filename);
        string GetOpenInBrowser(bool SameWindow);
        string GetPrintInBrowser(bool SameWindow);
        string GetEmbedInBrowserIframe(string IFrameQuerySelector);
        string GetDocumentDefinition();
        string GetBase64Data();
        uint[] GetBufferData();
        byte[] GetBlobData();
    }
}
