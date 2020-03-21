using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem4
    {
        public static bool IsP(int i)
        {
            var s = i.ToString();
            for (var j = 0; j < s.Length; j++)
            {
                if (s[j] != s[s.Length - j - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Is3(int i)
        {
            var s = i.ToString();
            return s.Length == 3;
        }


        public static void DoIt()
        {
            Console.WriteLine(
                "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\n\n" +
                "Find the largest palindrome made from the product of two 3-digit numbers.");

            var target = 999;
            Console.WriteLine($"Target: {target}");
            var maxes = new SortedDictionary<int, string>();

            for (var i = target; i > 0; i--)
            for (var j = target; j > 0; j--)
            {
                if (IsP(i * j) && Is3(i) && Is3(j) && !maxes.ContainsKey(i * j))
                {
                    maxes.Add(i * j, $"{i} * {j}");
                }
            }

            Console.WriteLine();

            Console.WriteLine(maxes.Last().Key);
            Console.WriteLine(maxes.Last().Value);
            Console.WriteLine(maxes.Count);
        }
    }
}