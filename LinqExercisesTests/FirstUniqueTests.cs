using Xunit;

namespace LinqExercises
{
    public class FirstUniqueTests
    {
        [Fact]
        public void GetUniqueLetter()
        {
            var input = new FirstUnique("aaabbbcyydpp");
            Assert.Equal('c', input.GetFirstUnique());
        }

        [Fact]
        public void GetUniqueChar()
        {
            var input = new FirstUnique("a.aabbbcyydpp");
            Assert.Equal('.', input.GetFirstUnique());
        }

        [Fact]
        public void GetUniqueCharDoesNotIgnoreCase()
        {
            var input = new FirstUnique("aaAbbbCcyydpp");
            Assert.Equal('A', input.GetFirstUnique());
        }
    }
}
