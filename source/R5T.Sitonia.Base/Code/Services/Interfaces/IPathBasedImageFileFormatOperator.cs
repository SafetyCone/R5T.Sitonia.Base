using System;

using R5T.Philippi;
using R5T.Sparta;


namespace R5T.Sitonia
{
    /// <summary>
    /// Gets the image <see cref="Philippi.FileFormat"/> based solely on analysis of the image file path string (does not read data, does not assume data exists).
    /// </summary>
    public interface IPathBasedImageFileFormatOperator
    {
        FileFormat GetFileFormat(FilePath imageFilePath);
    }
}
