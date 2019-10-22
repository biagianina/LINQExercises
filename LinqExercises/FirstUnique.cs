using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    public class FirstUnique
    {
        private readonly string input;

        public FirstUnique(string input)
        {
            this.input = input;
        }

        public char GetFirstUnique()
        {
            var charsIndexes = new Dictionary<char, List<int>>();
            foreach (char c in input)
            {
                if (charsIndexes.TryGetValue(c, out List<int> indexes))
                {
                    indexes.Add(input.IndexOf(c));
                }
                else
                {
                    charsIndexes.Add(c, new List<int> { input.IndexOf(c) });
                }
            }

            var indexOfFirstUniqueAppearance = charsIndexes.Select(c =>
            c.Value).Where(c =>
            c.Count == 1).Aggregate(input.Length, (index, c) =>
            index < c[0] ? index : c[0]);

            return input[indexOfFirstUniqueAppearance];
        }
    }
}
