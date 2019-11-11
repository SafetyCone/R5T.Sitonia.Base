using System;

using R5T.Philippi;
using R5T.Sparta;


namespace R5T.Sitonia
{
    /// <summary>
    /// Determines the image <see cref="Philippi.FileFormat"/> of an image file path.
    /// No assumption is made about whether an implementation can use file path, file data, or both to determine image file format.
    /// Check with the specific implementation for whether it assumes the image file specified by the image file path exists.
    /// </summary>
    public interface IImageFileFormatOperator
    {
        FileFormat GetFileFormat(FilePath imageFilePath);
    }
}
