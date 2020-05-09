using System.IO;

namespace Java2Core.Models
{
    public class ShellFile : BaseFile
    {
        public ShellFile(FileInfo fileInfo)
            : base(fileInfo, FileTypes.Script)
        {
        }
    }
}
