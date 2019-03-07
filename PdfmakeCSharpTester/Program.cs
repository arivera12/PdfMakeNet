using Jint;
using System;
using PdfMakeCSharp;
using System.Collections.Generic;

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

            pdfMake.AddText(new PdfMakeText()
            {
                Text = "First paragraph"
            });
            pdfMake.AddText(new PdfMakeText()
            {
                Text = "Another paragraph, this time a little bit longer to make sure, this line will be divided into at least two lines"
            });
            pdfMake.AddText(new List<PdfMakeText>() {
                new PdfMakeText()
                {
                    Text = "Hello ",
                    Color = "green",
                    Bold = true
                },
                new PdfMakeText()
                {
                    Text = "Pdfmake!",
                    Color = "purple",
                    Italics = true
                }
            });
            pdfMake.AddText(new PdfMakeText()
            {
                Text = "Page Break!",
                PageBreak = PageBreak.After,
                PageOrientation = PageOrientation.Landscape
            });
            pdfMake.AddText(new PdfMakeText()
            {
                Text = "Hello World in a new page in landscape, red, bold, aligned to the right, italics and with some margins!",
                Color = "red",
                Bold = true,
                Alignment = Alingment.Right,
                Italics = true,
                Margin = new int[] { 0, 50, 10, 30 }
            });
            pdfMake.AddText(new PdfMakeText()
            {
                Text = "Testing Qr code with foreground and background colors!",
            });
            pdfMake.AddQRCode(new PdfMakeQRCode()
            {
                Text = "My Awesome Qr Code!",
                Background = "black",
                Foreground = "red",
                Alignment = Alingment.Center
            });

            Console.WriteLine(pdfMake.GetDocumentDefinition());
        }
    }
}
