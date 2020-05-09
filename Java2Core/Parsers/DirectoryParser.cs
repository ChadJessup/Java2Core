using Java2Core.Interfaces;
using Java2Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Java2Core.Parsers
{
    public static class DirectoryParser
    {
        public static IDirectory Parse(DirectoryInfo dirInfo)
        {
            var parsedDir = new ParsedDirectory(dirInfo);

            foreach (var fileSystemInfo in parsedDir.Info
                .EnumerateFileSystemInfos("*.*", SearchOption.TopDirectoryOnly)
                .Where(fi => !fi.FullName.Contains(".git")))
            {
                switch (fileSystemInfo)
                {
                    case FileInfo fileInfo:
                        var parsedFile = Parse(fileInfo);
                        if (parsedFile != null)
                        {
                            parsedDir.Files.Add(parsedFile);
                        }
                        break;
                    case DirectoryInfo directoryInfo:
                        parsedDir.Directories.Add(Parse(directoryInfo));
                        break;
                    default:
                        break;
                }
            }

            return parsedDir;
        }

        static readonly HashSet<string> extensions = new HashSet<string>();
        private static IFile? Parse(FileInfo fileInfo)
        {
            IFile? parsedFile = null;

            switch (fileInfo.Extension)
            {
                case ".ps1":
                case ".bat":
                case ".sh":
                case ".cmd":
                    parsedFile = new ShellFile(fileInfo);
                    break;
                case ".html":
                case ".md":
                    parsedFile = new DocumentationFile(fileInfo);
                    break;
                case ".properties":
                case ".xml":
                case ".cfg":
                case ".conf":
                case ".gitignore":
                case ".yml":
                case ".yaml":
                case ".gradle":
                case FileExtensions.Json:
                    parsedFile = new ConfigurationFile(fileInfo);
                    break;
                case ".py":
                    parsedFile = new PythonFile(fileInfo);
                    break;
                case ".scala":
                    parsedFile = new ScalaFile(fileInfo);
                    break;
                case FileExtensions.Java:
                    parsedFile = new JavaSourceFile(fileInfo);
                    break;
                case ".png":
                default:
                    break;
            };

            if (parsedFile == null && extensions.Add(fileInfo.FullName))
            {
                Console.WriteLine(fileInfo.FullName);
            }

            return parsedFile;
        }
    }
}
