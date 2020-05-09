using System.IO;

namespace Java2Core.Models
{
    public class DocumentationFile : BaseFile
    {
        public DocumentationFile(FileInfo fileInfo)
            : base(fileInfo, FileTypes.Document)
        {
        }
    }
}
