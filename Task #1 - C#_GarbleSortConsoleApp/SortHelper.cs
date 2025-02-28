using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbleSortConsoleApp
{
    public static class SortHelper
    {
        public static List<int> GarbleSort(List<int> unorderedNumbers)
        {
            if (unorderedNumbers == null || unorderedNumbers.Count <= 1)
                return new List<int>(); // Return empty array to avoid null reference error

            var random = new Random();
            var garbled = new List<int>(unorderedNumbers);

            // Garble the list
            for (int i = garbled.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = garbled[i];
                garbled[i] = garbled[j];
                garbled[j] = temp;
            }

            return garbled;
        }
    }
}
