using System;
using System.IO;
using System.Text.Json;

namespace MenuSums
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No input file given.");

                return 1;
            }

            var fileName = args[0];

            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Input file given was not found.", fileName);
            }

            using var fileStream = File.OpenRead(fileName);
            using var document = JsonDocument.Parse(fileStream);

            foreach (var element in document.RootElement.EnumerateArray())
            {
                var count = 0;
                var items = element.GetProperty("menu").GetProperty("items");

                foreach (var item in items.EnumerateArray())
                {
                    if (item.ValueKind == JsonValueKind.Null) continue;

                    JsonElement label;
                    if (!item.TryGetProperty("label", out label)) continue;

                    var id = item.GetProperty("id").GetInt32();
                    count += id;
                }

                Console.WriteLine(count);
            }

            return 0;
        }
    }
}
