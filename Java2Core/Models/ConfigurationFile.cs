using System.IO;

namespace Java2Core.Models
{
    public class ConfigurationFile : BaseFile
    {
        public ConfigurationFile(FileInfo filePath)
            : base(filePath, FileTypes.Configuration)
        {
        }
    }
}
