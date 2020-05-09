using Java2Core.Parsers;
using System;
using System.IO;

namespace Java2Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2 || !Directory.Exists(args[0]))
            {
                Console.WriteLine("Provide input directory containing Java files");

                return;
            }

            Directory.CreateDirectory(args[1]);

            var prog = new Program();

            prog.ParseJavaFolder(inputFolder: args[0], outputFolder: args[1]);

            Console.WriteLine("Hello World!");
        }

        public ApplicationContext ParseJavaFolder(string inputFolder, string outputFolder)
        {
            var ac = new ApplicationContext
            {
                InputDirectory = new DirectoryInfo(inputFolder),
                OutputDirectory = new DirectoryInfo(outputFolder),
            };

            var parsedInputDirectory = DirectoryParser.Parse(ac.InputDirectory);

            ac.RootDirectory = parsedInputDirectory;

            return ac;
        }
    }
}
