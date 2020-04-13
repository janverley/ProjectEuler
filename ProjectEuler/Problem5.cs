using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem5
    {
        public static bool IsEvenlyDiv3(int i)
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
        
        public static bool IsEvenlyDiv(int i)
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

        public static void DoIt()
        {
            Console.WriteLine(
                "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder." +
                "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");

            var target = 2520;
            Console.WriteLine($"Target: {target}");

            var watch = new System.Diagnostics.Stopwatch();
            
            watch.Start();

            
            int i = 1;
            for (; true; i++)
            {
                if (IsEvenlyDiv3(i))
                {
                    break;
                }
            }
            
            Console.WriteLine(i);
            
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedTicks} ms");

        }
    }
}