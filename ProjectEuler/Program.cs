using System;

namespace ProjectEuler
{
    public static class Program
    {
        private static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Problem9.DoIt();
            
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}