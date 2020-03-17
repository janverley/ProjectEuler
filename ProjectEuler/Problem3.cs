using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem3
    {
        public static void DoIt()
        {
            Console.WriteLine("The prime factors of 13195 are 5, 7, 13 and 29.\n\nWhat is the largest prime factor of the number 600851475143 ?");

            var primes = new List<int>();

            var target = 600851475143;

            var max = target;

            Console.WriteLine($"Target: {target}");

            for (var i = 1; i <= max; i++)
            {
                if (target % i == 0 && primes.All(p => i % p != 0))
                {
                    if (i != 1)
                    {
                        max = max / i;
                        Console.WriteLine($"factor = {i}, max = {max}");
                        primes.Add(i);
                    }
                }
            }

            Console.WriteLine();

            if (primes.Count == 1)
            {
                Console.WriteLine($"{target} is a prime number");
            }
            else
            {
                Console.WriteLine(primes[^1]);
            }
        }
    }
}