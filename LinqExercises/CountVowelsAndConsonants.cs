using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    public class CountVowelsAndConsonants
    {
        readonly string input;
        readonly string vowels = "aeiou";

        public CountVowelsAndConsonants(string input)
        {
            this.input = input;
        }

        public (int, int) VowelsAndConsonantsCounter()
        {
            var result = (0, 0);
            result.Item1 = input.Aggregate(0, (count, c) =>
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
                else if (char.IsLetter(c))
                {
                    result.Item2++;
                }

                return count;
            });
            return result;
        }
    }
}
