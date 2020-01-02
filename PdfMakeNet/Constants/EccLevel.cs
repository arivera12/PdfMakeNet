using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class EccLevel
    {
        private static readonly Dictionary<string, EccLevel> Instance = new Dictionary<string, EccLevel>();
        private readonly string name;

        private EccLevel(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator EccLevel(string str)
        {
            return $"{FromString(str)}";
        }

        public static EccLevel FromString(string str)
        {
            if (Instance.TryGetValue(str, out EccLevel result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(EccLevel)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly EccLevel Low = new EccLevel("L");
        public static readonly EccLevel Medium = new EccLevel("M");
        public static readonly EccLevel Quartile = new EccLevel("Q");
        public static readonly EccLevel High = new EccLevel("H");
    }
}
