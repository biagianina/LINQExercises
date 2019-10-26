using System;
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
            var charsAndIndexes = input.Select((element, index) => new
            {
                Key = element,
                Value = index
            });

            var result = charsAndIndexes.Aggregate(new Dictionary<char, int>(), (checkDuplicates, element) =>
            {
                if (checkDuplicates.TryGetValue(element.Key, out int index))
                {
                    checkDuplicates[element.Key] = -1;
                }
                else
                {
                    checkDuplicates.Add(element.Key, element.Value);
                }

                return checkDuplicates;
            });

            var indexOfFirstUniqueAppearance = result.Select(c =>
            c.Value).First(c => c != -1);

            return input[indexOfFirstUniqueAppearance];
        }
    }
}
