using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PdfMakeNet.Extensions
{
    public static class StreamExtensions
    {
        public static byte[] ToByteArray(this Stream stream)
        {
            var streamLength = (int)stream.Length;
            var data = new byte[streamLength];
            stream.Read(data, 0, streamLength);
            return data;
        }
        public static async Task<byte[]> ToByteArrayAsync(this Stream stream)
        {
            var streamLength = (int)stream.Length;
            var data = new byte[streamLength];
            await stream.ReadAsync(data, 0, streamLength);
            return data;
        }
        public static async Task<byte[]> ToByteArrayAsync(this Stream stream, CancellationToken cancellationToken)
        {
            var streamLength = (int)stream.Length;
            var data = new byte[streamLength];
            await stream.ReadAsync(data, 0, streamLength, cancellationToken);
            return data;
        }
    }
}
