using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Exercise1011
    {
        public void SortValleyPeak(int[] array)
        {
            List<int> sorted = array.ToList();
            sorted.Sort();
            
            for(int i = 1; i < sorted.Count; i += 2)
                Swap(sorted, i - 1, i);
        }

        public void Swap(List<int> array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
