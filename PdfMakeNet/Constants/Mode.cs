using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class Mode
    {
        private static readonly Dictionary<string, Mode> Instance = new Dictionary<string, Mode>();
        private readonly string name;

        private Mode(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator Mode(string str)
        {
            return $"{FromString(str)}";
        }

        public static Mode FromString(string str)
        {
            if (Instance.TryGetValue(str, out Mode result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(Mode)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly Mode Numeric = new Mode("numeric");
        public static readonly Mode AlphaNumeric = new Mode("alphanumeric");
        public static readonly Mode Octet = new Mode("octet");
    }
}
