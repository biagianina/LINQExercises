using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        public static void Main()
        {
            var result = new PythagoreanTriples(new[] { 1, 2, 3, 4, 5 });
            foreach (var r in result.GetPythagoreanTriplets())
            {
                Console.WriteLine(r);
            }
        }
    }
}
