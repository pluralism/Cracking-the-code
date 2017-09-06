using System;

namespace ConsoleApp2
{
    class Program
    {
        static int[] PreProcess(string pattern)
        {
            int []pre = new int[pattern.Length];
            int j = 0, i = 1;
            pre[j] = 0;

            while(i < pattern.Length)
            {
                if(pattern[i] == pattern[j])
                    pre[i++] = ++j;
                else
                {
                    if(j != 0)
                        j = pre[j - 1];
                    else
                        pre[i++] = 0;
                }
            }
            return pre;
        }

        static void Main(string[] args)
        {
            string text = "ABABDABACDABABCABAB";
            string pattern = "ABABCABAB";
            int[] pre = PreProcess(pattern);
            int i = 0, j = 0;
            while(i < text.Length)
            {
                if(text[i] == pattern[j])
                {
                    i++;
                    j++;
                }

                if(j == pattern.Length)
                {
                    Console.WriteLine("Found a match at {0}", i - j);
                    j = pre[j - 1];
                } else if(pattern[j] != text[i])
                {
                    if (j != 0)
                        j = pre[j - 1];
                    else
                        i++;
                }
            }
            Console.ReadLine();
        }
    }
}
