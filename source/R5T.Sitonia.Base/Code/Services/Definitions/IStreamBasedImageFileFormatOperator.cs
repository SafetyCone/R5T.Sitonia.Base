using System;
using System.IO;

using R5T.Philippi;

using R5T.T0064;


namespace R5T.Sitonia
{
    /// <summary>
    /// Determines the image <see cref="FileFormat"/> format from the actual data of the image (most binary image formats contain header data identifying the image format).
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IStreamBasedImageFileFormatOperator : IServiceDefinition
    {
        FileFormat GetFileFormat(Stream imageFileStream);
    }
}
