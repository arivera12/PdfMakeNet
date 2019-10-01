using Newtonsoft.Json;

namespace PdfMakeCSharp
{
    public class PdfMakeTable<T> : PdfMakeStyle
    {
        /// <summary>
        /// Available table layouts: noBorders, headerLineOnly, lightHorizontalLines. You can do table layouts as well
        /// <see cref="https://pdfmake.github.io/docs/document-definition-object/tables/"/>
        /// </summary>
        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("table")]
        public PdfMakeTableBody<T> TableBody { get; set; }
    }
}
