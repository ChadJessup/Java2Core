using System.IO;

namespace Java2Core.Models
{
    public class PythonFile : BaseFile
    {
        public PythonFile(FileInfo fileInfo)
            : base(fileInfo, FileTypes.Source)
        {
        }
    }
}
