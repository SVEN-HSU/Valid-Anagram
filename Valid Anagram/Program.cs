// https://leetcode.com/problems/valid-anagram/
// Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isAnagram("anagram", "naamagr"));
            Console.Read();
        }

        public static bool isAnagram(string s, string t)
        {
            if (s == null)
            {
                return false;
            }

            if (t == null)
            {
                return false;
            }

            if (s.Length == 0 || t.Length == 0)
            {
                if (s.Length == 0 && t.Length == 0)
                {
                    return true;
                }

                return false;
            }


            return s.OrderBy(x => x).ToArray().SequenceEqual(t.OrderBy(x => x).ToArray());
        }
    }
}
