using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class Alingment
    {
        private static readonly Dictionary<string, Alingment> Instance = new Dictionary<string, Alingment>();
        private readonly string name;

        private Alingment(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator Alingment(string str)
        {
            return $"{FromString(str)}";
        }

        public static Alingment FromString(string str)
        {
            if (Instance.TryGetValue(str, out Alingment result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(Alingment)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly Alingment Left = new Alingment("left");
        public static readonly Alingment Right = new Alingment("right");
        public static readonly Alingment Center = new Alingment("center");
        public static readonly Alingment Justify = new Alingment("justify");
    }
}
