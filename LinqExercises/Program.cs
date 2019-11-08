using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        public static void Main()
        {
            var numbers = new PythagoreanTriples(new[] { 5, 4, 3, 2, 1 });
            foreach (var el in numbers.GetPythagoreanTriplets())
            {
                    Console.WriteLine(el);
            }
        }
    }
}
