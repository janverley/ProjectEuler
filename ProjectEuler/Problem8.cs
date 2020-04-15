using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem8
    {
        public static void DoIt()
        {
            Console.WriteLine(
                "The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.\n\n73167176531330624919225119674426574742355349194934\n96983520312774506326239578318016984801869478851843\n85861560789112949495459501737958331952853208805511\n12540698747158523863050715693290963295227443043557\n66896648950445244523161731856403098711121722383113\n62229893423380308135336276614282806444486645238749\n30358907296290491560440772390713810515859307960866\n70172427121883998797908792274921901699720888093776\n65727333001053367881220235421809751254540594752243\n52584907711670556013604839586446706324415722155397\n53697817977846174064955149290862569321978468622482\n83972241375657056057490261407972968652414535100474\n82166370484403199890008895243450658541227588666881\n16427171479924442928230863465674813919123162824586\n17866458359124566529476545682848912883142607690042\n24219022671055626321111109370544217506941658960408\n07198403850962455444362981230987879927244284909188\n84580156166097919133875499200524063689912560717606\n05886116467109405077541002256983155200055935729725\n71636269561882670428252483600823257530420752963450\n\nFind the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?");

            var target = 13;

            var s =
                "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            var ai = new int[1000];

            var i = 0;
            foreach (var c in s)
            {
                ai[i++] = Int32.Parse(c.ToString());
            }

            Int64 maxProd = 0;
            var maxProds = "";
            for (int j = 0; j < 1000 - target; j++)
            {
                Int64 prod = 1;
                var prods = "";
                for (int k = 0; k < target; k++)
                {
                    var x = ai[j + k];
                    if (x == 0)
                    {
//                        Console.WriteLine($"***** 0 *****");
                    }
                    
                    prod = prod * ai[j+k];
                    prods += $" * {ai[j + k]}";
                }

                // if (prod > 0 && prod.Length() >= 10)
                // {
                //       Console.WriteLine($"{prods} = [{prod.Length()}]{prod} ");
                // }

                if (prod > maxProd)
                {
                    maxProd = prod;
                    maxProds = prods;
                }
            }
            
            
            Console.WriteLine($"Target: {maxProds}");
            Console.WriteLine($"Target: {maxProd}");
        }
    }
}