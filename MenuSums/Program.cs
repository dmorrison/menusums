using System;
using System.IO;

namespace MenuSums
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Argument for input file was not given.");

                return 1;
            }

            var path = args[0];

            // TODO: Consider showing a usage error if file specified doesn't exist. As
            // is, a FileNotFoundException will be thrown.
            // TODO: Consider using async version of this method.
            var json = File.ReadAllText(path);

            var sums = MenuSummer.CalculateSums(json);

            foreach (var sum in sums)
            {
                Console.WriteLine(sum);
            }

            return 0;
        }
    }
}
