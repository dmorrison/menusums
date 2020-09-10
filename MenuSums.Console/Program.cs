using System;

namespace MenuSums
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // TODO: Use more specific exception type here?
                throw new Exception("No input file given.");
            }

            Console.WriteLine($"First arg: {args[0]}");
        }
    }
}
