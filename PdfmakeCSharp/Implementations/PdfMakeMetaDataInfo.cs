using MessagePack;

namespace PdfmakeCSharp
{
    [MessagePackObject]
    public class PdfMakeMetaDataInfo
    {
        [Key("title")]
        public string Title { get; set; }
        [Key("author")]
        public string Author { get; set; }
        [Key("subject")]
        public string Subject { get; set; }
        [Key("keywords")]
        public string Keywords { get; set; }
        [Key("creator")]
        public string Creator { get; set; }
        [Key("producer")]
        public string Producer { get; set; }
        [Key("creationDate")]
        public string CreationDate { get; set; }
        [Key("modDate")]
        public string ModDate { get; set; }
        [Key("trapped")]
        public bool Trapped { get; set; }
    }
}
