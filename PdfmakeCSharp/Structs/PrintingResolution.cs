using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public struct PrintingResolution
    {
        public const string HighResolution = "highResolution";
        public const string LowResolution = "lowResolution";
    }
}
