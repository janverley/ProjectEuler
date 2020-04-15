using System;

namespace ProjectEuler
{
    public static class Extensions
    {
        public static bool IsPrimeNumber(this int i)
        {
            var max = i / 2;
            for (int j = 2; j <= max; j++)
            {
                var x = i % j;
                if (x ==0)
                {
                    return false;
                }
            }
            return true;
        }

        
        public static int Length(this int i)
        {
            var s = i.ToString();
            return s.Length;
        }
        public static bool Is3Long(this int i)
        {
            var s = i.ToString();
            return s.Length == 3;
        }

        public static bool IsPalindrome(this int i)
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

        public static bool IsEvenlyDiv(this int i)
        {
            for (int j = 1; j < 20; j++)
            {
                var x = i % j;
                if (x !=0)
                {
                    //Console.WriteLine($"{i} is niet deelbaar door {j} > false");
                    return false;
                }
            }

            return true;
        }

        public static bool IsEvenlyDiv3(this int i)
        {
            for (int j = 20; j > 1; j--)
            {
                var x = i % j;
                if (x !=0)
                {
                    //Console.WriteLine($"{i} is niet deelbaar door {j} > false");
                    return false;
                }
            }

            return true;
        }

        public static int SquareOfSums(this int i)
        {
            var result = 0;
            for (int j = 1; j <= i; j++)
            {
                result += j;
            }

            return result * result;
        }

        public static int SumOfSquares(this int i)
        {
            var result = 0;
            for (int j = 1; j <= i; j++)
            {
                result += (j * j);
            }

            return result;
        }

        public static bool IsInt(this double d)
        {
            return Math.Abs(d - Math.Floor(d)) < 0.00001;
        }
    }
}