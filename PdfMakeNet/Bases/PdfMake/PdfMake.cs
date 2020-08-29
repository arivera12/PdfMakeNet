using Newtonsoft.Json;
using PdfMakeNet.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PdfMakeNet
{
    public class PdfMake : IPdfMake
    {
        /// <summary>
        /// The header section
        /// </summary>
        [JsonProperty("header")]
        public IList<object> Header { get; set; }
        /// <summary>
        /// The footer section
        /// </summary>
        [JsonProperty("footer")]
        public IList<object> Footer { get; set; }
        /// <summary>
        /// The body section
        /// </summary>
        [JsonProperty("content")]
        public IList<object> Body { get; set; }
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
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PageSize PageSize { get; set; }
        /// <summary>
        /// The page margins option
        /// </summary>
        [JsonProperty("pageMargins")]
        public IList<int> PageMargins { get; set; }
        /// <summary>
        /// The page orientation option
        /// </summary>
        [JsonProperty("pageOrientation")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PageOrientation PageOrientation { get; set; }
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
        public IPdfMakePermissions Permissions { get; set; }
        /// <summary>
        /// Adds water mark to the pdf document
        /// </summary>
        [JsonProperty("watermark")]
        public IPdfMakeWaterMark PdfMakeWaterMark { get; set; }
        /// <summary>
        /// Default constuctor
        /// </summary>
        public PdfMake()
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        public PdfMake(PageSize pageSize)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="compress"></param>
        public PdfMake(bool compress)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Compress = compress;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        public PdfMake(string userPassword, string ownerPassword)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="permissions"></param>
        public PdfMake(IPdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Permissions = permissions;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        public PdfMake(PageSize pageSize, bool compress)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(PageSize pageSize, IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(PageSize pageSize, bool compress, IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        public PdfMake(PageSize pageSize, bool compress, string userPassword, string ownerPassword)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(PageSize pageSize, bool compress, string userPassword, string ownerPassword, IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        public PdfMake(PageSize pageSize, bool compress, string userPassword, string ownerPassword, IPdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(PageSize pageSize, bool compress, string userPassword, string ownerPassword, IPdfMakePermissions permissions, IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        public PdfMake(bool compress, string userPassword, string ownerPassword)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(bool compress, string userPassword, string ownerPassword, IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        public PdfMake(bool compress, string userPassword, string ownerPassword, IPdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        public PdfMake(string userPassword, string ownerPassword, IPdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(string userPassword, string ownerPassword, IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        /// <param name="pdfMakeWaterMark"></param>
        public PdfMake(string userPassword, string ownerPassword, IPdfMakePermissions permissions, IPdfMakeWaterMark pdfMakeWaterMark)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
            PdfMakeWaterMark = pdfMakeWaterMark;
        }
        /// <summary>
        /// Add a PdfMake element the body section
        /// </summary>
        /// <param name="pdfmakeObject"></param>
        public void AddBody<T>(T pdfmakeObject)
        {
            Body.Add(pdfmakeObject);
        }
        /// <summary>
        /// Adds a qr code to the body section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddBodyQRCode(IPdfMakeQRCode qRCode)
        {
            Body.Add(qRCode);
        }
        /// <summary>
        /// Adds a string to the body section
        /// </summary>
        /// <param name="text"></param>
        public void AddBodyText(string text)
        {
            Body.Add(text);
        }
        /// <summary>
        /// Adds a IList of string to the body section
        /// </summary>
        /// <param name="texts"></param>
        public void AddBodyText(IEnumerable<string> texts)
        {
            Body.Add(texts);
        }
        /// <summary>
        /// Adds a text to the body section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddBodyText(IPdfMakeText PdfMakeText)
        {
            Body.Add(PdfMakeText);
        }
        /// <summary>
        /// Add a IList of texts to the body section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        public void AddBodyText<T>(IPdfMakeTexts<T> PdfMakeTexts)
        {
            Body.Add(PdfMakeTexts);
        }
        /// <summary>
        /// Adds columns to the body section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddBodyColumns<T>(IPdfMakeColumns<T> Columns)
        {
            Body.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the body section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddBodyTable<T>(IPdfMakeTable<T> pdfMakeTable)
        {
            Body.Add(pdfMakeTable);
        }
        /// <summary>
        ///  Adds a ordered IList to the body section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddBodyOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList)
        {
            Body.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered IList to the body section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddBodyUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList)
        {
            Body.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the body section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddBodyStack<T>(IPdfMakeStack<T> pdfMakeStacks)
        {
            Body.Add(pdfMakeStacks);
        }
        /// <summary>
        /// Adds an image to the body section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddBodyImage(IPdfMakeImage pdfMakeImage)
        {
            Body.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds an Svg to the body section
        /// </summary>
        /// <param name="pdfMakeSvg"></param>
        public void AddBodySvg(IPdfMakeSvg pdfMakeSvg)
        {
            Body.Add(pdfMakeSvg);
        }
        /// <summary>
        /// Adds a link to the body section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddBodyLink(IPdfMakeLink pdfMakeLink)
        {
            Body.Add(pdfMakeLink);
        }
        /// <summary>
        /// Adds a table of content to the body section
        /// </summary>
        /// <param name="pdfMakeTableOfContent"></param>
        public void AddTableOfContent(IPdfMakeTableOfContent pdfMakeTableOfContent)
        {
            Body.Add(pdfMakeTableOfContent);
        }
        /// <summary>
        /// Add a PdfMake element the header section
        /// </summary>
        /// <param name="pdfmakeObject"></param>
        public void AddHeader<T>(T pdfmakeObject)
        {
            Header.Add(pdfmakeObject);
        }
        /// <summary>
        /// Adds a qr code to the header section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddHeaderQRCode(IPdfMakeQRCode qRCode)
        {
            Header.Add(qRCode);
        }
        /// <summary>
        /// Adds a string to the header section
        /// </summary>
        /// <param name="text"></param>
        public void AddHeaderText(string text)
        {
            Header.Add(text);
        }
        /// <summary>
        /// Adds a IList of string to the header section
        /// </summary>
        /// <param name="text"></param>
        public void AddHeaderText(IEnumerable<string> texts)
        {
            Header.Add(texts);
        }
        /// <summary>
        /// Adds a text to the header section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddHeaderText(IPdfMakeText PdfMakeText)
        {
            Header.Add(PdfMakeText);
        }
        /// <summary>
        /// Add a IList of texts to the header section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        public void AddHeaderText<T>(IPdfMakeTexts<T> PdfMakeTexts)
        {
            Header.Add(PdfMakeTexts);
        }
        /// <summary>
        ///  Adds text to the header section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddHeaderColumns<T>(IPdfMakeColumns<T> Columns)
        {
            Header.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the header section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddHeaderTable<T>(IPdfMakeTable<T> pdfMakeTable)
        {
            Header.Add(pdfMakeTable);
        }
        /// <summary>
        /// Adds a ordered IList to the header section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddHeaderOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList)
        {
            Header.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered IList to the header section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddHeaderUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList)
        {
            Header.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the header section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddHeaderStack<T>(IPdfMakeStack<T> pdfMakeStacks)
        {
            Header.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the header section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddHeaderImage(IPdfMakeImage pdfMakeImage)
        {
            Header.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds an Svg to the body header
        /// </summary>
        /// <param name="pdfMakeSvg"></param>
        public void AddHeaderSvg(IPdfMakeSvg pdfMakeSvg)
        {
            Header.Add(pdfMakeSvg);
        }
        /// <summary>
        /// Adds a link to the header section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddHeaderLink(IPdfMakeLink pdfMakeLink)
        {
            Header.Add(pdfMakeLink);
        }
        /// <summary>
        /// Add a PdfMake element the footer section
        /// </summary>
        /// <param name="pdfmakeObject"></param>
        public void AddFooter<T>(T pdfmakeObject)
        {
            Footer.Add(pdfmakeObject);
        }
        /// <summary>
        /// Adds a qr code to the footer section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddFooterQRCode(IPdfMakeQRCode qRCode)
        {
            Footer.Add(qRCode);
        }
        /// <summary>
        /// Adds a string to the footer section
        /// </summary>
        /// <param name="text"></param>
        public void AddFooterText(string text)
        {
            Footer.Add(text);
        }
        /// <summary>
        /// Adds a IList of string to the footer section
        /// </summary>
        /// <param name="text"></param>
        public void AddFooterText(IEnumerable<string> texts)
        {
            Footer.Add(texts);
        }
        /// <summary>
        /// Adds a text to the footer section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddFooterText(IPdfMakeText PdfMakeText)
        {
            Footer.Add(PdfMakeText);
        }
        /// <summary>
        /// Add a IList of texts to the footer section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        public void AddFooterText<T>(IPdfMakeTexts<T> PdfMakeTexts)
        {
            Footer.Add(PdfMakeTexts);
        }
        /// <summary>
        /// Adds a columns to the footer section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddFooterColumns<T>(IPdfMakeColumns<T> Columns)
        {
            Footer.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the footer section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddFooterTable<T>(IPdfMakeTable<T> pdfMakeTable)
        {
            Footer.Add(pdfMakeTable);
        }
        /// <summary>
        /// Adds a ordered IList to the footer section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddFooterOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList)
        {
            Footer.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered IList to the footer section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddFooterUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList)
        {
            Footer.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the footer section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddFooterStack<T>(IPdfMakeStack<T> pdfMakeStacks)
        {
            Footer.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the footer section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddFooterImage(IPdfMakeImage pdfMakeImage)
        {
            Footer.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds an Svg to the body footer
        /// </summary>
        /// <param name="pdfMakeSvg"></param>
        public void AddFooterSvg(IPdfMakeSvg pdfMakeSvg)
        {
            Footer.Add(pdfMakeSvg);
        }
        /// <summary>
        /// Adds a link to the footer section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddFooterLink(IPdfMakeLink pdfMakeLink)
        {
            Footer.Add(pdfMakeLink);
        }
        /// <summary>
        /// Reads an Image from an http request and converts it to its base 64 representation with its data uri format ready to be embed. 
        /// This method specs that the resource is an image type compatible with pdfmake.
        /// JPEG and PNG formats are supported.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="httpMethod"></param>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public static async Task<string> LoadImageFromUrlAsync(HttpClient httpClient, string httpMethod, string requestUri, SourceImageFormat sourceImageFormat)
        {
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), requestUri);
            var response = await httpClient.SendAsync(request);
            var stream = await response.Content.ReadAsStreamAsync();
            var byteArray = await stream.ToByteArrayAsync();
            var base64StringImage = Convert.ToBase64String(byteArray);
            return $"data:{sourceImageFormat.GetMimeType()};base64,{base64StringImage}";
        }
        /// <summary>
        /// Reads an Image from an http request and converts it to its base 64 representation with its data uri format ready to be embed. 
        /// This method specs that the resource is an image type compatible with pdfmake.
        /// JPEG and PNG formats are supported.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="httpMethod"></param>
        /// <param name="requestUri"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<string> LoadImageFromUrlAsync(HttpClient httpClient, string httpMethod, string requestUri, SourceImageFormat sourceImageFormat, CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), requestUri);
            var response = await httpClient.SendAsync(request);
            var stream = await response.Content.ReadAsStreamAsync();
            var byteArray = await stream.ToByteArrayAsync(cancellationToken);
            var base64StringImage = Convert.ToBase64String(byteArray);
            return $"data:{sourceImageFormat.GetMimeType()};base64,{base64StringImage}";
        }
        /// <summary>
        /// Reads an svg text from an http request.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="httpMethod"></param>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        public static async Task<string> LoadSvgFromUrlAsync(HttpClient httpClient, string httpMethod, string requestUri)
        {
            var request = new HttpRequestMessage(new HttpMethod(httpMethod), requestUri);
            var response = await httpClient.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }
        /// <summary>
        /// Reads an image from the system file and converts it to its base 64 representation with its data uri format ready to be embed.
        /// This method specs that the resource is an image type compatible with pdfmake.
        /// JPEG and PNG formats are supported.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sourceImageFormat"></param>
        /// <returns></returns>
        public static string LoadImageFromPath(string path, SourceImageFormat sourceImageFormat)
        {
            var byteArray = File.ReadAllBytes(path);
            var base64StringImage = Convert.ToBase64String(byteArray);
            return $"data:{sourceImageFormat.GetMimeType()};base64,{base64StringImage}";
        }
    }
}
