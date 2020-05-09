using Java2Core.Models;
using System.IO;

namespace Java2Core.Interfaces
{
    public static class FileExtensions
    {
        public const string Json = ".json";
        public const string Java = ".java";
    }

    public interface IFile
    {
        FileInfo FilePath { get; }
        FileTypes FileType { get; }
    }
}
