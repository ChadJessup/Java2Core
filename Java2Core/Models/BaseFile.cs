using Java2Core.Interfaces;
using System.IO;

namespace Java2Core.Models
{
    public abstract class BaseFile : IFile
    {
        protected BaseFile(FileInfo filePath, FileTypes fileType)
        {
            this.FilePath = filePath;
            this.FileType = fileType;
        }

        public virtual FileInfo FilePath { get; }
        public virtual FileTypes FileType { get; }

        public override string ToString()
            => $"{this.FilePath.Name}";
    }
}
