using Jint;
using System;
using PdfMakeCSharp;
using System.Collections.Generic;

namespace PdfmakeCSharpTester
{
    class Program
    {
        static readonly PdfMake pdfMake = new PdfMake();
        static void Main(string[] args)
        {
            TestPdfMakeObjectStructure();
            TestJint();
        }

        private static void TestJint()
        {
            //var PdfMakeLib = PdfMakeCSharp.IO.ReadEmbeddedResource.ReadResourceContent("pdfmake.min.js");
            //var PdfMakeFonts = PdfMakeCSharp.IO.ReadEmbeddedResource.ReadResourceContent("vfs_fonts.js");
            var engine = new Engine();

            //var result = engine.Execute(
            //    PdfMakeLib + 
            //    " " + 
            //    PdfMakeFonts + 
            //    " " + 
            //    @"
            //    pdfMake.createPdf(" + pdfMake.GetDocumentDefinition() + @").getBase64(function(data) {
            //        return data;
            //    }); 
            //")
            //.GetCompletionValue()
            //.ToObject();

            //Testing callbacks
            var result = engine.Execute(
                @"
                var myfunction = function fu(callback) { return callback('noob') };
                myfunction(function(data) { return data;  });
            ")
            .GetCompletionValue()
            .ToObject();

            Console.WriteLine(result);
        }

        static void TestPdfMakeObjectStructure()
        {
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
            pdfMake.AddText(new PdfMakeText()
            {
                Text = "PdfMake Table Test",
            });
            pdfMake.AddTable(new PdfMakeTable<object>()
            {
                TableBody = new PdfMakeTableBody<object>()
                {
                    HeaderRows = 1,
                    Body = new List<object>()
                    {
                        new List<string>()
                        {
                            "Column1",
                            "Column2"
                        },
                        new List<string>()
                        {
                            "row11",
                            "row21"
                        },
                        new List<string>()
                        {
                            "row12",
                            "row22"
                        }
                    }
                }
            });
            pdfMake.AddText(new PdfMakeText()
            {
                Text = "PdfMake Table Test using helper method on primitive datatype",
            });
            pdfMake.AddTable(new PdfMakeTable<object>()
            {
                TableBody = new PdfMakeTableBody<object>()
                {
                    HeaderRows = 1,
                    Body = pdfMake.AddTableBodyStructure(
                        new List<string>()
                        {
                            "Column1",
                            "Column2"
                        },
                        new List<object>()
                        {
                            new List<string>()
                            {
                                "row11",
                                "row21"
                            },
                            new List<string>()
                            {
                                "row12",
                                "row22"
                            }
                        }
                    )
                }
            });
            pdfMake.AddText(new PdfMakeText()
            {
                Text = "PdfMake Table Test using helper method on anonymous object",
            });
            pdfMake.AddTable(new PdfMakeTable<object>()
            {
                TableBody = new PdfMakeTableBody<object>()
                {
                    HeaderRows = 1,
                    Body = pdfMake.AddTableBodyStructure(
                        new List<string>()
                        {
                            "Column1",
                            "Column2"
                        },
                        new List<object>()
                        {
                            new
                            {
                                c0 = "row11",
                                c1 = "row21"
                            },
                            new
                            {
                                c0 = "row12",
                                c1 = "row22"
                            },
                            new
                            {
                                c0 = "row13",
                                c1 = "row23"
                            }
                        }
                    )
                }
            });
            Console.WriteLine(pdfMake.GetDocumentDefinition());
        }
    }
}
