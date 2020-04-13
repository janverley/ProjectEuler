using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem6
    {
        public static int SumOfSquares(int i)
        {
            var result = 0;
            for (int j = 1; j <= i; j++)
            {
                result += (j * j);
            }

            return result;
        }

        public static int SquareOfSums(int i)
        {
            var result = 0;
            for (int j = 1; j <= i; j++)
            {
                result += j;
            }

            return result * result;
        }
        public static void DoIt()
        {
            Console.WriteLine(
                "The sum of the squares of the first ten natural numbers is,\n\n12+22+...+102=385\nThe square of the sum of the first ten natural numbers is,\n\n(1+2+...+10)2=552=3025\nHence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025−385=2640.\n\nFind the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");

            var target = 100;
            Console.WriteLine($"Target: {target}");

            var watch = new System.Diagnostics.Stopwatch();
            
            watch.Start();

            var soq = SumOfSquares(target);
            var qos = SquareOfSums(target);
            
            Console.WriteLine($"{qos} - {soq} = {qos - soq}");
            
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedTicks} ms");

        }
    }
}