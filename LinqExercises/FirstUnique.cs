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

        public string GetFirstUnique()
        {
            return input.GroupBy(c => c.ToString(), StringComparer.OrdinalIgnoreCase).
                First(c => c.Count() == 1).Key;
        }
    }
}
