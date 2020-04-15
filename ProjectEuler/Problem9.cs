using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem9
    {
        public static double FindC(int a, int b)
        {
            return Math.Sqrt(a*a + b * b);
        }

        public static void DoIt()
        {
            Console.WriteLine(
                "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,\n\na2 + b2 = c2\nFor example, 32 + 42 = 9 + 16 = 25 = 52.\n\nThere exists exactly one Pythagorean triplet for which a + b + c = 1000.\nFind the product abc.");
                
            var target = 1000;


            for (int i = 0; i < 1000; i++)
            {

                for (int j = i; j < 1000; j++)
                {
                    var c = FindC(i, j);
                    if (!c.IsInt())
                    {
                        continue;
                    }

                    var sum = i + j + c;

                    if (sum == 1000.0)
                    {
                        var prod = i * j * c;
                        Console.WriteLine($"Target: {i} {j} {c}    {prod}");
                        
                    }
                }
                
            }
            
            
            
            
            Console.WriteLine($"Target: {target}");
        }
    }
}