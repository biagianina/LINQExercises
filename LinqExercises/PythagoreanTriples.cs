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

        public IEnumerable<(int, int, int)> GetPythagoreanTriplets()
        {
            Func<int, int, int, bool> isPythagoreanTriplet = (a, b, c) => (a < b) && a * a + b * b == c * c;
            return GenerateCombinations()
                .Where(c => isPythagoreanTriplet(c.Item1, c.Item2, c.Item3))
                .OrderBy(x => x.Item1);
        }

        public IEnumerable<(int, int, int)> GenerateCombinations()
        {
            return numbers.SelectMany((e1, index) => numbers.Skip(index + 1)
                .SelectMany((e2, index2) => numbers.Skip(index + index2 + 1 + 1)
                    .SelectMany(e3 => GeneratePermutations((e1, e2, e3)))));
        }

        private IEnumerable<(int, int, int)> GeneratePermutations((int, int, int) triplet) => new List<(int, int, int)>
        {
                (triplet.Item1, triplet.Item2, triplet.Item3),
                (triplet.Item1, triplet.Item3, triplet.Item2),
                (triplet.Item2, triplet.Item1, triplet.Item3),
                (triplet.Item2, triplet.Item3, triplet.Item1),
                (triplet.Item3, triplet.Item1, triplet.Item2),
                (triplet.Item3, triplet.Item2, triplet.Item1)
        };
    }
}
