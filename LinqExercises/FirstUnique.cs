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
            var charsIndexes = new Dictionary<char, int>();
            int i = 0;
            while (i < input.Length)
            {
                if (charsIndexes.TryGetValue(input.ElementAt(i), out int index))
                {
                    charsIndexes[input.ElementAt(i)] = -1;
                    i++;
                }
                else
                {
                    charsIndexes.Add(input.ElementAt(i), i);
                    i++;
                }
            }

            var indexOfFirstUniqueAppearance = charsIndexes.Select(c =>
            c.Value).Where(c =>
            c != -1).Aggregate(input.Length, (index, c) =>
            index < c ? index : c);

            return input[indexOfFirstUniqueAppearance];
        }
    }
}
