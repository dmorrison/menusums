using System.Collections.Generic;
using System.Text.Json;

namespace MenuSums
{
    public static class MenuSummer
    {
        /// <summary>
        /// Given the file name of a JSON file containing an array of menu objects,
        /// outputs a list containing sums of ids for each valid item within a
        /// menu. A menu item is valid if it has a label specified.
        /// </summary>
        /// <param name="json">JSON string to parse.</param>
        /// <returns>List of id sums.</returns>
        public static List<int> CalculateSums(string json)
        {
            var counts = new List<int>();

            var options = new JsonDocumentOptions { AllowTrailingCommas = true };
            using var document = JsonDocument.Parse(json, options);

            foreach (var element in document.RootElement.EnumerateArray())
            {
                var count = 0;

                if (!element.TryGetProperty("menu", out JsonElement menuElement))
                {
                    continue;
                }

                if (!menuElement.TryGetProperty("items", out JsonElement items))
                {
                    continue;
                }

                foreach (var item in items.EnumerateArray())
                {
                    if (item.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }

                    if (!item.TryGetProperty("label", out JsonElement label))
                    {
                        continue;
                    }

                    var id = item.GetProperty("id").GetInt32();
                    count += id;
                }

                counts.Add(count);
            }

            return counts;
        }
    }
}
