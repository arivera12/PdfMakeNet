# PdfMakeNet
<p>
    <a href="https://www.nuget.org/packages/PdfMakeNet">
         <img src="https://buildstats.info/nuget/PdfMakeNet?v=1.0.5" />
     </a>
     <a href="https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=RSE2NMEG3F7QU&source=url">
         <img src="https://img.shields.io/badge/Donate-PayPal-green.svg" />
     </a>
</p>

c# wrapper for [PdfMake](http://pdfmake.org/#/).

<b>Note: Before accesing the site please <i>disable add blocker</i> while on the site or whitelist it to PdfMakeNet work properly, you won't get any output with add blocker on.</b>

### [Live Demo](https://sc231997.github.io/PdfMakeNet/)

Demo live site credits to [sc231997](https://github.com/sc231997).

### Implemented and Pending Features

* [x] line-wrapping
* [x] text-alignments
  * [x] left
  * [x] right
  * [x] centered
  * [x] justified
* [x] numbered and bulleted lists
* [x] tables and columns
  *  [x] auto/fixed/star-sized widths
  *  [x] col-spans and row-spans
  *  [x] headers automatically repeated in case of a page-break
  *  [ ] access to row number of table
  *  [ ] access to layout functions
* [x] images
* [x] SVGs
* [ ] vector graphics
* [x] convenient styling and style inheritance
* [x] page headers and footers
  * [x] static or dynamic content
  * [ ] access to current page number and page count
* [x] background-layer
* [x] page dimensions and orientations
* [x] margins
* [x] custom page breaks
* [ ] font embedding (default at the moment)
* [x] support for complex, multi-level (nested) structures
* [x] table of contents
* [x] Watermark
* [x] Extension methods for opening/printing/downloading the generated PDF
* [x] setting of PDF metadata (e.g. author, subject)
* [x] compression
* [x] encryption and access privileges
  * [x] user password
  * [x] owner password
  * [x] printing
  * [x] modifying
  * [x] copying
  * [x] annotating
  * [x] filling forms
  * [x] content accessibility
  * [x] document assembly
* [x] client-side extension methods
  * [x] download with the specified filename
  * [x] open in same or another window
  * [x] print auto-triggering print

## Notes

This wrapper implements the same methods and options as pdfmake and will help you build pdfmake object structure more faster and easier using strong datatypes and some extension methods using c#.

Take note that this library as no server side render capabilities yet (Unless integration with NodeJs or any lib on c# that parses and executes javascript, if any one want these feature please file an issue with any recommendation or pull request).

Maybe is some near future PdfMakeNet and others js libs may be posible to execute over c# using [Jint](https://github.com/sebastienros/jint) after they complete the implementations of ES5 and ES6 features.

I opened this issue on Jint repository to keep track of this. [Run PdfMake on Jint](https://github.com/sebastienros/jint/issues/609)

Another library that maybe another alternative [ChakraCore](https://github.com/microsoft/ChakraCore)

So based on the last sentence you still need to reference pdfmake.js and vfs_fonts.js files on your client or create your own pdfmake viewer for flawless integration.

## Documentation

The code is already documented but if you want more documentation you can visit: https://pdfmake.github.io/docs/

## Browsers Supported

https://pdfmake.github.io/docs/getting-started/client-side/supported-browsers/

## Installation

### Install Nuget Package 

```
Install-Package PdfMakeNet -Version 1.0.5
```
```
Install-Package PdfMakeNet.Server.Extensions -Version 1.0.5
```

### Include the pdfmake script and font

```
<script src='build/pdfmake.min.js'></script>
<script src='build/vfs_fonts.js'></script>
```

## Basic Example

```
using PdfMakeNet;

var pdfmake = new PdfMake();
pdfmake.AddText(new PdfMakeText() 
{ 
  Alignment = Alingment.Center,
  BackgroundColor = "red",
  Bold = true,
  Color = "white",
  FontSize = 18,
  Italics = true,
  Text = "Hello World!"
});
Console.WriteLine(pdfmake.GetDocumentDefinition());
```

## Issues

If you find any bug or issue please file an issue I will fix it as soon as posible.

## Pull Request

Pull requests are welcome. Please submit a pull request letting me know if is a bug fix or new feature.

## License
MIT

## Contributors
- [arivera](https://github.com/arivera12) (founder)
- [sc231997](https://github.com/sc231997)
