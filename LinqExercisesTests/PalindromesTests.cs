using System.Collections.Generic;
using Xunit;

namespace LinqExercises
{
    public class PalindromesTests
    {
        [Fact]
        public void StringIsPalindrome()
        {
            var input = new Palindromes("aba");
            List<string> result = new List<string> { "a", "b", "a", "aba" };
            Assert.Equal(result, input.GetPalindromes());
        }

        [Fact]
        public void MultiplePalindroms()
        {
            var input = new Palindromes("aabaac");
            List<string> result = new List<string> { "a", "a", "b", "a", "a", "c", "aa", "aa", "aba", "aabaa" };
            Assert.Equal(result, input.GetPalindromes());
        }
    }
}
