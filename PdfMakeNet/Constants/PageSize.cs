using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class PageSize
    {
        private static readonly Dictionary<string, PageSize> Instance = new Dictionary<string, PageSize>();
        private readonly string name;

        private PageSize(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator PageSize(string str)
        {
            return $"{FromString(str)}";
        }

        public static PageSize FromString(string str)
        {
            if (Instance.TryGetValue(str, out PageSize result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(PageSize)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly PageSize _4A0 = new PageSize("4A0");
        public static readonly PageSize _2A0 = new PageSize("2A0");
        public static readonly PageSize A0 = new PageSize("A0");
        public static readonly PageSize A1 = new PageSize("A1");
        public static readonly PageSize A2 = new PageSize("A2");
        public static readonly PageSize A3 = new PageSize("A3");
        public static readonly PageSize A4 = new PageSize("A4");
        public static readonly PageSize A5 = new PageSize("A5");
        public static readonly PageSize A6 = new PageSize("A6");
        public static readonly PageSize A7 = new PageSize("A7");
        public static readonly PageSize A8 = new PageSize("A8");
        public static readonly PageSize A9 = new PageSize("A9");
        public static readonly PageSize A10 = new PageSize("A10");
        public static readonly PageSize B0 = new PageSize("B0");
        public static readonly PageSize B1 = new PageSize("B1");
        public static readonly PageSize B2 = new PageSize("B2");
        public static readonly PageSize B3 = new PageSize("B3");
        public static readonly PageSize B4 = new PageSize("B4");
        public static readonly PageSize B5 = new PageSize("B5");
        public static readonly PageSize B6 = new PageSize("B6");
        public static readonly PageSize B7 = new PageSize("B7");
        public static readonly PageSize B8 = new PageSize("B8");
        public static readonly PageSize B9 = new PageSize("B9");
        public static readonly PageSize B10 = new PageSize("B10");
        public static readonly PageSize C0 = new PageSize("C0");
        public static readonly PageSize C1 = new PageSize("C1");
        public static readonly PageSize C2 = new PageSize("C2");
        public static readonly PageSize C3 = new PageSize("C3");
        public static readonly PageSize C4 = new PageSize("C4");
        public static readonly PageSize C5 = new PageSize("C5");
        public static readonly PageSize C6 = new PageSize("C6");
        public static readonly PageSize C7 = new PageSize("C7");
        public static readonly PageSize C8 = new PageSize("C8");
        public static readonly PageSize C9 = new PageSize("C9");
        public static readonly PageSize C10 = new PageSize("C10");
        public static readonly PageSize RA0 = new PageSize("RA0");
        public static readonly PageSize RA1 = new PageSize("RA1");
        public static readonly PageSize RA2 = new PageSize("RA2");
        public static readonly PageSize RA3 = new PageSize("RA3");
        public static readonly PageSize RA4 = new PageSize("RA4");
        public static readonly PageSize SRA0 = new PageSize("SRA0");
        public static readonly PageSize SRA1 = new PageSize("SRA1");
        public static readonly PageSize SRA2 = new PageSize("SRA2");
        public static readonly PageSize SRA3 = new PageSize("SRA3");
        public static readonly PageSize SRA4 = new PageSize("SRA4");
        public static readonly PageSize EXECUTIVE = new PageSize("EXECUTIVE");
        public static readonly PageSize FOLIO = new PageSize("FOLIO");
        public static readonly PageSize LEGAL = new PageSize("LEGAL");
        public static readonly PageSize LETTER = new PageSize("LETTER");
        public static readonly PageSize TABLOID = new PageSize("TABLOID");
    }
}
