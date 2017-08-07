using System;

namespace ConsoleApp2
{
    class Morton
    {
        static void Main(string[] args)
        {
            long n = 10, 
                 m = 7, 
                 res = 0;
            int i = 0;
            long max = Math.Max(m, n), min = Math.Min(m, n);
            while(max > 0)
            {
                res |= (min & 1) << (2 * i) | (max & 1) << (2 * i++ + 1);
                min >>= 1; max >>= 1;
            }
            Console.WriteLine(Convert.ToString(res, 2));
        }
    }
}
