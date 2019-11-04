using Xunit;

namespace LinqExercises
{
    public class MaximumCharacterOccurancesTests
    {
        [Fact]
        public void GetCharacterFromOneCharacterInput()
        {
            var input = new MaximumCharacterOccurances("a");
            Assert.Equal('a', input.GetCharacterWithMaximumOccurances());
        }

        [Fact]
        public void GetCorrectCharacterFromInput()
        {
            var input = new MaximumCharacterOccurances("aaabbbbcddddd453");
            Assert.Equal('d', input.GetCharacterWithMaximumOccurances());
        }
    }
}
