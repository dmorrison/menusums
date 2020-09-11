using System.Collections.Generic;
using System.Text.Json;

namespace MenuSums
{
    public static class MenuSummer
    {
        /// <summary>
        /// Given a string of JSON containing an array of menu objects, outputs
        /// a list containing sums of ids for each valid item within a menu. A
        /// menu item is valid if it has a label specified.
        /// </summary>
        /// <param name="json">JSON string to parse.</param>
        /// <returns>List of id sums.</returns>
        public static List<int> CalculateSums(string json)
        {
            var sums = new List<int>();

            var options = new JsonDocumentOptions { AllowTrailingCommas = true };
            using var document = JsonDocument.Parse(json, options);

            foreach (var element in document.RootElement.EnumerateArray())
            {
                var sum = 0;

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
                    // Skip invalid items (null, missing required keys, etc.).
                    if (item.ValueKind == JsonValueKind.Null
                        || !item.TryGetProperty("label", out JsonElement label)
                        || !item.TryGetProperty("id", out JsonElement id)
                        || !id.TryGetInt32(out int idValue))
                    {
                        continue;
                    }

                    sum += idValue;
                }

                sums.Add(sum);
            }

            return sums;
        }
    }
}
