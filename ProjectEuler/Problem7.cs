using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem7
    {
        public static bool IsPrimeNumber(int i)
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
        
        public static void DoIt()
        {
            Console.WriteLine(
                "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\n\nWhat is the 10 001st prime number?");

            var target = 10001;
            Console.WriteLine($"Target: {target}");

            var watch = new System.Diagnostics.Stopwatch();
            
            watch.Start();

            var idx = 0;
            
            for (int i = 2;true; i++)
            {
                if (IsPrimeNumber(i))
                {
                    idx++;
                    Console.WriteLine($"{idx}: {i}");

                    if (idx == target)
                    {
                        break;
                    }
                }
            }
            
            
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedTicks} ms");

        }
    }
}