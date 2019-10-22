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
            var duplicateCheck = new HashSet<char>();
            var duplicates = input.Aggregate("", (acumulator, element) =>
            !duplicateCheck.Add(element) ? acumulator + element : acumulator);
            return input.Except(duplicates).First();
        }
    }
}
