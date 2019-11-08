using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    public class PythagoreanTriples
    {
        readonly int[] numbers;

        public PythagoreanTriples(int[] numbers)
        {
            this.numbers = numbers;
        }

        public IEnumerable<Tuple<int, int, int>> GetPythagoreanTriplets()
        {
            Func<int, int, int, bool> isPythagoreanTriplet = (a, b, c) => a * a + b * b == c * c;
            return GetCombinationsOfThreeFromN()
                .Where(c => isPythagoreanTriplet(c.Item1, c.Item2, c.Item3));
        }

        private IEnumerable<Tuple<int, int, int>> GetCombinationsOfThreeFromN()
        {
            return numbers.SelectMany((e1, index) => numbers.Skip(index + 1)
                  .SelectMany((e2, index2) => numbers.Skip((index + 1) + (index2 + 1))
                      .Select(e3 => Tuple.Create(e1, e2, e3))));
        }
    }
}
