using System.Collections.Generic;

namespace JsonParser
{
    public class NumberExtractor
    {
        public List<int> ExtractNumbersToAdd(Menu menu)
        {
            var numbers = new List<int>();
            foreach (var item in menu.Items)
            {
                if (item != null && !string.IsNullOrEmpty(item.Label) && item.Id != 0)
                {
                    numbers.Add(item.Id);
                }
            }
            return numbers;
        }
    }
}