using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem5
    {
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
                if (i.IsEvenlyDiv3())
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