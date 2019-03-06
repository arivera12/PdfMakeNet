using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public struct PageBreak
    {
        public const string After = "after";
        public const string Before = "before";
    }
}
