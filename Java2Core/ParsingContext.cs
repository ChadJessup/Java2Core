using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Java2Core
{
    public class ParsingContext
    {
        public string RootNamespace { get; set; } = "Kafka.Streams";
        public bool UseSameFolderStructure { get; set; } = true;

        public DirectoryInfo? InputDirectory { get; set; }
        public DirectoryInfo? TemporaryDirectory { get; set; }
        public DirectoryInfo? OutputDirectory { get; set; }
    }
}
