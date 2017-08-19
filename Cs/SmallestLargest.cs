using System;

namespace ConsoleApp2
{
    class Program
    {
        static int Next(int n)
        {
            int c = n;
            int c0 = 0, c1 = 0;
            while(((c & 1) == 0) && (c != 0))
            {
                c0++;
                c >>= 1;
            }

            while((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            int p = c0 + c1;
            int a = 1 << p; // all 0, except at position p
            int b = a - 1; // p ones
            int mask = ~b;
            n = n & mask; // clear rightmost p bits

            a = 1 << (c1 - 1); // subtract one "1", because it was added in position "p"
            b = a - 1;
            return n | b;
        }

        static void Main(string[] args)
        {

        }
    }
}
