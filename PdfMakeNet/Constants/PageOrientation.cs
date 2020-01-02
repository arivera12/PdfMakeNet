using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class PageOrientation
    {
        private static readonly Dictionary<string, PageOrientation> Instance = new Dictionary<string, PageOrientation>();
        private readonly string name;

        private PageOrientation(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator PageOrientation(string str)
        {
            return $"{FromString(str)}";
        }

        public static PageOrientation FromString(string str)
        {
            if (Instance.TryGetValue(str, out PageOrientation result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(PageOrientation)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly PageOrientation Landscape = new PageOrientation("landscape");
        public static readonly PageOrientation Portrait = new PageOrientation("portrait");
    }
}
