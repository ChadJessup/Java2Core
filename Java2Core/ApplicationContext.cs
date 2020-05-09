using Java2Core.Interfaces;
using System.IO;

namespace Java2Core
{
    public class ApplicationContext
    {
        public string RootNamespace { get; set; } = "Kafka.Streams";
        public bool UseSameFolderStructure { get; set; } = true;

        public DirectoryInfo? InputDirectory { get; set; }
        public DirectoryInfo? TemporaryDirectory { get; set; }
        public DirectoryInfo? OutputDirectory { get; set; }

        public IDirectory? RootDirectory { get; set; }
    }
}
