namespace PdfMakeNet.Extensions
{
    public static class SourceImageFormatExtensions
    {
        public static string GetMimeType(this SourceImageFormat sourceImageFormat)
        {
            if (sourceImageFormat == SourceImageFormat.JPEG)
            {
                return "image/jpeg";
            }
            else if (sourceImageFormat == SourceImageFormat.PNG)
            {
                return "image/png";
            }
            return null;
        }
    }
}
