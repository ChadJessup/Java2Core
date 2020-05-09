using System.Collections.Generic;
using System.IO;

namespace Java2Core.Interfaces
{
    public interface IDirectory
    {
        public string Name { get; }
        public DirectoryInfo Info { get; }
        List<IDirectory> Directories { get; }
        List<IFile> Files { get; }
    }
}
