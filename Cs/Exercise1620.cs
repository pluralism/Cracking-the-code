using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exercise1620
    {
        char[][] t9Letters = { null, null, new char[] { 'a', 'b', 'c' }, new char[] { 'd', 'e', 'f' }, new char[] { 'g', 'h', 'i' },
        new char[] { 'j', 'k', 'l' }, new char[] { 'm', 'n', 'o' }, new char[] { 'p', 'q', 'r', 's' }, new char[] { 't', 'u', 'v' },
        new char[] { 'w', 'x', 'y', 'z' } };

        public void GetValidWords(string number, int index, string prefix, HashSet<string> wordSet, List<string> results)
        {
            if(index == number.Length && wordSet.Contains(prefix))
            {
                results.Add(prefix);
                return;
            }

            char digit = number[index];
            // Get characters that match this digit
            char[] letters = GetT9Chars(digit);

            // Go through all the remaining options
            if(letters != null)
            {
                foreach(char letter in letters)
                {
                    GetValidWords(number, index + 1, prefix +  letter, wordSet, results);
                }
            }
        }

        public char[] GetT9Chars(char digit)
        {
            if(!int.TryParse(digit.ToString(), out _))
            {
                return null;
            }

            int value = Convert.ToInt32(digit) - Convert.ToInt32('0');
            return t9Letters[value];
        }

        public List<string> GetValidT9Words(string number, HashSet<string> validWords)
        {
            List<string> results = new List<string>();
            return results;
        }
    }
}
