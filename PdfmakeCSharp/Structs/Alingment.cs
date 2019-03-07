using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public struct Alingment
    {
        public const string Left = "left";
        public const string Right = "right";
        public const string Center = "center";
        public const string Justify = "justify";
    }
}
