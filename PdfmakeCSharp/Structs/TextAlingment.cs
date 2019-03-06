using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public struct TextAlingment
    {
        public const string Left = "left";
        public const string Right = "rigth";
        public const string Center = "center";
        public const string Justify = "justify";
    }
}
