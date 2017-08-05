using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1024; // 10000000000
            int m = 19; // 10011
            int i = 2, j = 6;
            for (int k = i; k <= j; k++) n &= ~(1 << k);
            m <<= i;
            n |= m;
            Console.WriteLine(Convert.ToString(n, 2));
        }
    }
}
