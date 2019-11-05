using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    public class Palindromes
    {
        readonly string input;

        public Palindromes(string input)
        {
            this.input = input;
        }

        public List<string> GetPalindromes()
        {
            Func<string, bool> checkPalindrome = str
                => str.ToCharArray()
                    .SequenceEqual(str.Reverse());
            var substrings = GetSubstrings(input);
            return substrings.Where(c => checkPalindrome(c)).ToList();
        }

        private IOrderedEnumerable<string> GetSubstrings(string input)
        {
            return Enumerable.Range(0, input.Length)
                .SelectMany(i => Enumerable.Range(1, input.Length - i)
                .Select(j => input.Substring(i, j)))
                .OrderBy(s => s.Length);
        }
    }
}
