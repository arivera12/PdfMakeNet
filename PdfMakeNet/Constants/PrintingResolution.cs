using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class PrintingResolution
    {
        private static readonly Dictionary<string, PrintingResolution> Instance = new Dictionary<string, PrintingResolution>();
        private readonly string name;

        private PrintingResolution(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator PrintingResolution(string str)
        {
            return $"{FromString(str)}";
        }

        public static PrintingResolution FromString(string str)
        {
            if (Instance.TryGetValue(str, out PrintingResolution result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(PrintingResolution)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly PrintingResolution HighResolution = new PrintingResolution("highResolution");
        public static readonly PrintingResolution LowResolution = new PrintingResolution("lowResolution");
    }
}
