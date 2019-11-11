using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace LinqExercises
{
    public class WordsTop : IEqualityComparer<(string, int)>
    {
        private readonly string[] text;

        public WordsTop(string text)
        {
            this.text = text.Split();
        }

        public bool Equals((string, int) x, (string, int) y)
        {
            return x.Item1.Equals(y.Item1) &&
                x.Item2.Equals(y.Item2);
        }

        public int GetHashCode((string, int) obj)
        {
            return obj.GetHashCode();
        }

        public IEnumerable<(string, int)> Top()
        {
            return text.GroupBy(x => x)
                .Select(x => (x.Key, x.Count()))
                .OrderByDescending(x => x.Item2);
        }
    }
}
