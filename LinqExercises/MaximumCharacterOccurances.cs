using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExercises
{
    public class MaximumCharacterOccurances
    {
        readonly string input;

        public MaximumCharacterOccurances(string input)
        {
            this.input = input;
        }

        public char GetCharacterWithMaximumOccurances()
        {
            var occurancesCounter = input.Aggregate(new Dictionary<char, int>(), (occurances, c) =>
            {
                if (occurances.TryGetValue(c, out int numberOfOccurances))
                {
                    occurances[c]++;
                }
                else
                {
                    occurances.Add(c, 1);
                }

                return occurances;
            });

            return occurancesCounter.Select(c => c).Aggregate(new KeyValuePair<char, int>(), (max, c) =>
            max.Value > c.Value ? max : c).Key;
        }
    }
}
