using System.IO;

namespace Java2Core.Models
{
    public class ScalaFile : BaseFile
    {
        public ScalaFile(FileInfo fileInfo)
            : base(fileInfo, FileTypes.Source)
        {
        }
    }
}
