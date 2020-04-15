using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem7
    {
        public static void DoIt()
        {
            Console.WriteLine(
                "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\n\nWhat is the 10 001st prime number?");

            var target = 10001;
            Console.WriteLine($"Target: {target}");

            var idx = 0;
            
            for (int i = 2;true; i++)
            {
                if (i.IsPrimeNumber())
                {
                    idx++;
                    Console.WriteLine($"{idx}: {i}");

                    if (idx == target)
                    {
                        break;
                    }
                }
            }
            
        }
    }
}