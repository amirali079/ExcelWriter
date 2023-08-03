using ICSharpCode.SharpZipLib.BZip2;

namespace ReadExcel;

// use SharpZipLib 1.4.2
public class CompressSample
{
    private static Stream Decompress(Stream readStream)
    {
        var memoryStream = new MemoryStream();

        BZip2.Decompress(readStream, memoryStream, false);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return memoryStream;
    }

}