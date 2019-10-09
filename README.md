# PdfMakeNet

c# wrapper for [PdfMake](http://pdfmake.org/#/)

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
* [x] images 
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
* [x] helper methods for opening/printing/downloading the generated PDF
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
* [x] client-side helper methods
  * [x] download with the specified filename
  * [x] open in another tab
  * [x] print auto-triggering print

## Documentation

This wrapper implements the same methods and options as pdfmake but using strong datatypes in c#.

The code is already documented but if you want more documentation you can visit: https://pdfmake.github.io/docs/

## Nuget (Available Soon) 

```
Install-Package PdfMakeNet
```

## License
MIT

## Examples

Examples will be available soon.
