using System;
using System.IO;

namespace Java2Core
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || !Directory.Exists(args[0]))
            {
                Console.WriteLine("Provide input directory containing Java files");

                return;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
