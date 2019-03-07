using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public class PdfMakeTable<T> : PdfMakeStyle
    {
        /// <summary>
        /// Available table layouts: noBorders, headerLineOnly, lightHorizontalLines. You can do table layouts as well
        /// <see cref="https://pdfmake.github.io/docs/document-definition-object/tables/"/>
        /// </summary>
        [Key("layout")]
        public string Layout { get; set; }

        [Key("table")]
        public PdfMakeTableBody<T> TableBody { get; set; }
    }
}
