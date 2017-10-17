using System.Linq;

namespace ConsoleApp1
{
    static class Extensions
    {
        public static bool IsEmpty(this string str)
        {
            return str.Count() == 0;
        }
    }

    class Exercise104
    {
        public Exercise104() { }

        public int Search(string[] strings, string str, int first, int last)
        {
            if (first > last)
                return -1;
            int mid = (first + last) / 2;

            if(strings[mid].IsEmpty())
            {
                int left = mid - 1;
                int right = mid + 1;
                while(true)
                {
                    if (left < first && right > last)
                        return -1;
                    else if(right <= last && !strings[right].IsEmpty())
                    {
                        mid = right;
                        break;
                    } else if(left >= first && !strings[left].IsEmpty())
                    {
                        mid = left;
                        break;
                    }
                    right++;
                    left--;
                }
            }

            if (str == strings[mid])
                return mid;
            else if (strings[mid].CompareTo(str) < 0)
                return Search(strings, str, mid + 1, last);
            else
                return Search(strings, str, first, mid - 1);
        }

        public int Search(string[] strings, string str)
        {
            if (strings == null || str == null || str.Length == 0)
                return -1;
            return Search(strings, str, 0, strings.Length - 1);
        }
    }
}
