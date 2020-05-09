using Java2Core.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace Java2Core.Models
{
    public class ParsedDirectory : IDirectory
    {
        public ParsedDirectory(DirectoryInfo info)
        {
            this.Name = info.Name;
            this.Info = info;
        }

        public string Name { get; }
        public DirectoryInfo Info { get; }
        public List<IDirectory> Directories { get; } = new List<IDirectory>();
        public List<IFile> Files { get; } = new List<IFile>();

        public override string ToString()
            => $"{this.Name}";
    }
}
