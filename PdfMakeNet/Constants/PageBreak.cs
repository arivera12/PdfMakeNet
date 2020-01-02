using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class PageBreak
    {
        private static readonly Dictionary<string, PageBreak> Instance = new Dictionary<string, PageBreak>();
        private readonly string name;

        private PageBreak(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator PageBreak(string str)
        {
            return $"{FromString(str)}";
        }

        public static PageBreak FromString(string str)
        {
            if (Instance.TryGetValue(str, out PageBreak result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(PageBreak)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly PageBreak After = new PageBreak("after");
        public static readonly PageBreak Before = new PageBreak("before");
    }
}
