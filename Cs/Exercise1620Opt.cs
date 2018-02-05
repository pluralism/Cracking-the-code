using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exercise1620Opt
    {
        char[][] t9Letters = { null, null, new char[] { 'a', 'b', 'c' }, new char[] { 'd', 'e', 'f' }, new char[] { 'g', 'h', 'i' },
        new char[] { 'j', 'k', 'l' }, new char[] { 'm', 'n', 'o' }, new char[] { 'p', 'q', 'r', 's' }, new char[] { 't', 'u', 'v' },
        new char[] { 'w', 'x', 'y', 'z' } };

        // Maps letters to numbers
        Dictionary<char, char> CreateLetterToNumberMap()
        {
            Dictionary<char, char> letterToNumberMap = new Dictionary<char, char>();
            for(int i = 0; i < t9Letters.Length; i++)
            {
                char[] letters = t9Letters[i];
                if(letters != null)
                {
                    foreach(char c in letters)
                    {
                        var res = Convert.ToInt32(c.ToString(), 10);
                        letterToNumberMap[c] = (char) (res + 0x30);
                    }
                }
            }
            return letterToNumberMap;
        }

        // Convert a string to T9
        public string ConvertToT9(string word, Dictionary<char, char> letterToNumberMap)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in word)
            {
                if(letterToNumberMap.TryGetValue(c, out char res))
                {
                    sb.Append(res);
                }
            }
            return sb.ToString();
        }

        Dictionary<string, string> InitializeDictionary(string[] words)
        {
            Dictionary<char, char> letterToNumberMap = CreateLetterToNumberMap();
            Dictionary<string, string> wordsToNumber = new Dictionary<string, string>();

            foreach(string word in words)
            {
                wordsToNumber.Add(word, ConvertToT9(word, letterToNumberMap));
            }

            return wordsToNumber;
        }
    }
}
