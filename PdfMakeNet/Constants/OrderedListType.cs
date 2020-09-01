using System;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public sealed class OrderedListType
    {
        private static readonly Dictionary<string, OrderedListType> Instance = new Dictionary<string, OrderedListType>();
        private readonly string name;

        private OrderedListType(string name)
        {
            this.name = name;
            Instance[name] = this;
        }

        public static implicit operator OrderedListType(string str)
        {
            return $"{FromString(str)}";
        }

        public static OrderedListType FromString(string str)
        {
            if (Instance.TryGetValue(str, out OrderedListType result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException($"{nameof(OrderedListType)} must be one of the followings https://pdfmake.github.io/docs/");
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }

        public static readonly OrderedListType LowerAlpha = new OrderedListType("lower-alpha");
        public static readonly OrderedListType UpperAlpha = new OrderedListType("upper-alpha");
        public static readonly OrderedListType LowerRoman = new OrderedListType("lower-roman");
        public static readonly OrderedListType UpperRoman = new OrderedListType("upper-roman" );
        public static readonly OrderedListType None = new OrderedListType("none");
    }
}
