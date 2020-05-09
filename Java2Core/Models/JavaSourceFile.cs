using System.IO;

namespace Java2Core.Models
{
    public class JavaSourceFile : BaseFile
    {
        public JavaSourceFile(FileInfo filePath)
            : base(filePath, FileTypes.Source)
        {
        }
    }
}
