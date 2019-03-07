using Jint;
using System;
using PdfMakeCSharp;

namespace PdfmakeCSharpTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //var PdfMake = PdfMakeCSharp.IO.ReadEmbeddedResource.ReadResourceContent("pdfmake.min.js");
            //var Fonts = PdfMakeCSharp.IO.ReadEmbeddedResource.ReadResourceContent("vfs_fonts.js"); 
            //var engine = new Engine();

            //engine.Execute(PdfMake);
            //engine.Execute(Fonts);

            TestPdfMakeObjectStructure();
        }

        static void TestPdfMakeObjectStructure()
        {
            PdfMake pdfMake = new PdfMake();

            pdfMake.AddText(new PdfMakeText() { Text = "Hello World!", PageBreak = PageBreak.After, PageOrientation = PageOrientation.Landscape });
            pdfMake.AddText(new PdfMakeText() { Text = "Hello World in a new page in landscape!" });

            Console.WriteLine(pdfMake.GetDocumentDefinition());
        }
    }
}
