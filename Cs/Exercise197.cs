using System;

namespace ConsoleApp1
{
    class Exercise107
    {
        public void FindOpenNumber()
        {
            long numberOfInts = (long) int.MaxValue + 1;
            byte[] bitField = new byte[(int) (numberOfInts / 8)];
            long count = 0;
            while(count < 4_000_000_000)
            {
                int tmp = Convert.ToInt32(Console.ReadLine());
                bitField[tmp / 8] |= (byte) (1 << (tmp % 8));
                count++;
            }

            // For each byte
            for(int i = 0; i < bitField.Length; i++)
            {
                // For each bit of the ith byte
                for(int j = 0; j < 8; j++)
                {
                    if((bitField[i] & (1 << j)) == 0)
                    {
                        Console.WriteLine(i * 8 + j);
                        return;
                    }
                }
            }
        }
    }
}
