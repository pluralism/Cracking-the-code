using System;
using System.Collections;

namespace ConsoleApp1
{
    class Exercise108
    {
        public void CheckDuplicates(int[] array)
        {
            BitArray bitArray = new BitArray(32000);
            for(int i = 0; i < array.Length; i++)
            {
                int tmp = array[i];
                int index = tmp - 1;
                if (bitArray.Get(index))
                    Console.WriteLine(tmp);
                else
                    bitArray.Set(index, true);
            }
        }
    }
}
