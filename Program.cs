using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLearn
{
    class Program
    {
        static char firstNotRepeatingCharacter_01(string s)
        {
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                bool seenDuplicate = false;
                for (int j = 0; j < len; ++j)
                {
                    if (s[i] == s[j] && i != j)
                    {
                        seenDuplicate = true;
                        break;
                    }
                }
                if (!seenDuplicate)
                    return s[i];
            }
            return '-';
        }
        static char firstNotRepeatingCharacter_02(string s)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = s[i];
                if (pairs.ContainsKey(c))
                    pairs[c] = pairs[c] + 1;
                else
                    pairs[c] = 1;
            }
            for (int i = 0; i < len; ++i)
            {
                char c = s[i];
                if (pairs[c] == 1)
                    return c;
            }
            return '-';
        }
        static char firstNotRepeatingCharacter_03(string s)
        {
            int[] char_counts = new int[26];
            int len = s.Length;
            for (int i = 0; i < len; ++i)
                char_counts[s[i] - 'a']++;
            for (int i = 0; i < len; ++i)
                if (char_counts[s[i] - 'a'] == 1)
                    return s[i];
            return '-';
        }
        static char firstNotRepeatingCharacter_04(string s)
        {
            for (int i = 0; i < s.Length; ++i)
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                    return s[i];
            return '-';
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
