using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class UnorderedListType
    {
        private static readonly Dictionary<string, UnorderedListType> Instance = new Dictionary<string, UnorderedListType>();
        private readonly string name;

        private UnorderedListType(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator UnorderedListType(string str)
        {
            return $"{FromString(str)}";
        }

        public static UnorderedListType FromString(string str)
        {
            if (Instance.TryGetValue(str, out UnorderedListType result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(UnorderedListType)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly UnorderedListType Square = new UnorderedListType("square");
        public static readonly UnorderedListType Circle = new UnorderedListType("circle");
        public static readonly UnorderedListType None = new UnorderedListType("none");
    }
}
