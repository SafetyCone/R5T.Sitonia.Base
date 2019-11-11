using System;
using System.IO;

using R5T.Philippi;


namespace R5T.Sitonia
{
    /// <summary>
    /// Determines the image <see cref="Philippi.FileFormat"/> format from the actual data of the image (most binary image formats contain header data identifying the image format).
    /// </summary>
    public interface IStreamBasedImageFileFormatOperator
    {
        FileFormat GetFileFormat(Stream imageFileStream);
    }
}
