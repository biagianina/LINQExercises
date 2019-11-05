using System;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main()
        {
            foreach (var s in new GivenSumSubarrays(new[] { 1, 2, 3, 4, 5, 6 }, 6).GetSubarrayWithSumK())
            {
                foreach (var c in s)
                {
                    Console.Write(c);
                }

                Console.WriteLine();
            }
        }
    }
}
