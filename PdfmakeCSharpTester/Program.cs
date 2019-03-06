using Jint;
using System;
using PdfMakeCSharp;

namespace PdfmakeCSharpTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //var baseScript = PdfmakeCSharp.IO.ReadEmbeddedResource.ReadResourceContent("pdfmake.min.js");

            //var engine = new Engine();

            //engine.Execute(baseScript);

            TestPdfMakeObjectStructure();
        }

        static void TestPdfMakeObjectStructure()
        {
            PdfMake pdfMake = new PdfMake();

            pdfMake.AddText(new PdfMakeText() { Text = "Hello World!" });

            Console.WriteLine(pdfMake.GetDocumentDefinition());
        }
    }
}
