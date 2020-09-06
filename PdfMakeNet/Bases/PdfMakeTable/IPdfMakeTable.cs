using Newtonsoft.Json;

namespace PdfMakeNet
{
    public interface IPdfMakeTable<T> : IPdfMakeStyle
    {
        /// <summary>
        /// Adds a layout ot the table
        /// Available table layouts: noBorders, headerLineOnly, lightHorizontalLines. You can do your own table layouts as well
        /// <see cref="https://pdfmake.github.io/docs/document-definition-object/tables/"/>
        /// </summary>
        [JsonProperty("layout")]
        object Layout { get; set; }
        /// <summary>
        /// Adds a table
        /// </summary>
        [JsonProperty("table")]
        PdfMakeTableBody<T> TableBody { get; set; }
    }
}
