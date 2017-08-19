using System;

namespace ConsoleApp2
{
    class Program
    {
        static int Flip(int n)
        {
            int len = 1, curLength = 0, prevLength = 0;
            while(n != 0)
            {
                if ((n & 1) == 1)
                    curLength++;
                else
                {
                    prevLength = (n & 2) == 0 ? 0 : curLength;
                    curLength = 0;
                }
                len = Math.Max(prevLength + curLength + 1, len);
                n >>= 1;
            }
            return len;
        }

        static void Main(string[] args)
        {

        }
    }
}
