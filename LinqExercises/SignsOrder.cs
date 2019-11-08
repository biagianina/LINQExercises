using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    public class SignsOrder
    {
        private readonly int n;
        private readonly int k;

        public SignsOrder(int n, int k)
        {
            this.n = n;
            this.k = k;
        }

        public IEnumerable<string> GenerateEquationsEqualToK()
        {
            return GenerateEquationsAndResults()
                .Where(equation => equation.Item2 == k)
                .Select(equation => equation.Item1 + " = " + k);
        }

        private IEnumerable<(string, int)> GenerateEquationsAndResults()
        {
            return GenerateSigns()
                .Select(Calculate);
        }

        private (string, int) Calculate(string s)
        {
            return s.Select((s, index) => (s, index))
                .Aggregate(("", 0), (result, x) => Calculate(result, x));
        }

        private (string, int) Calculate((string, int) result, (char s, int index) x)
        {
            return x.s.Equals('+') ?
                (result.Item1 + "+" + (x.index + 1), result.Item2 + (x.index + 1)) :
                (result.Item1 + "-" + (x.index + 1), result.Item2 - (x.index + 1));
        }

        private IEnumerable<string> GenerateSigns()
        {
            IEnumerable<string> seed = new[] { "" };
            return Enumerable.Range(1, n)
                .Aggregate(seed, (res, x) =>
                    res.SelectMany(x => new[] { x + "+", x + "-" }));
        }
    }
}
