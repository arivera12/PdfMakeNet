# PdfMakeNet
<p>
    <a href="https://www.nuget.org/packages/PdfMakeNet">
         <img src="https://buildstats.info/nuget/PdfMakeNet?v=1.0.5" />
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

## Developer Farewell Note
	
It has been a lifetime for me to work as a developer, as an employee as well as a professional service provider, but it is very sad to have been working for the last 12 years on more than 40+ projects in the banking industry, payment processing, government applications, web servers, databases, reports, web and mobile applications, github contributions in different projects including my personal ones and never see economic growth.

I have been exploited, I have even done developments that gave me half or less or they never paid me even under contracts.

Once, some time ago, I developed an application to serve and help citizens and the same government ended up giving the idea to a third service provider who developed it and were the ones who sold it to them and to other entities.

That filled me with a lot of anger and frustration because I wasted 1 year of my life for nothing, just like the 12 that I currently have.

I have always had good will together with many ideas of how to change the way we develop, but nobody has given me the opportunity to be heard and I have never had a problem that I could not solve, because I solve problems by the nature of my profession.

My idea of ​​programming templates and functionalities has been an idea that took me about 8 years to perfect and that would save any entity millions in development costs but nobody seems to see the fruit of the effort I have put into it.

I have submitted my development tool and no one seems to be interested, I have contacted microsoft several times, I have contacted PRITS several times and have never been answered.

I tried to sell my product on various sites and well I have reached a point in my life where I am very frustrated, unfocused and no longer feel love or passion for what I do.

I have completely lost interest in everything in life and honestly I have a family to support and I have lost what little I had when I have never had anything in my life.

I come from a poor and dysfunctional family who have never supported me.

That is not why you have to follow the same negative pattern.

You and all of us can make a difference, but when you are poor the things around you are almost like a curse.

It takes much more than good ideas to be successful, you have to have connections, you have to have a good presentation, you have to be tactful when speaking and know how to sell, you have to know how to implement things correctly by phase, you have to have a reputation for everything.

Surround yourself with positive people who are willing to help you or they are not affected by seeing you grow but that is where I have unintentionally failed.

Family circles and friends who have never given me any help or support and there is nothing worse than looking back and seeing how long I have walked alone, then I look at the present and I am still just as alone and there is no way to progress in that way.

You have to open your eyes, take a deep breath, see things as they are and know when to retire with dignity.

I don't know if I'll be back tomorrow, I just don't know.

I only leave this note here for interested developers to contribute.

I will leave everything there public and transparent as I have always been.

Life is hard, and when you cling to something that is hurting you, just let it go and seek to change your path.

I wish that many people benefit from my contributions and ideas, that at least my lost time will save time for other developers.

Of what one day was a dream for me, has been thrown into darkness.
