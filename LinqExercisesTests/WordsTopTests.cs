using System.Collections.Generic;
using Xunit;

namespace LinqExercises
{
    public class WordsTopTests
    {
        [Fact]
        public void SimpleText()
        {
            var result = new WordsTop("This is a text").Top();
            var expected = new List<(string, int)>
            {
                ("This", 1),
                ("is", 1),
                ("a", 1),
                ("text", 1)
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void MoreOccurancesOfWordsText()
        {
            var result = new WordsTop("This is a text with a text counter").Top();
            var expected = new List<(string, int)>
            {
                ("a", 2),
                ("text", 2),
                ("This", 1),
                ("is", 1),
                ("with", 1),
                ("counter", 1)
            };
            Assert.Equal(expected, result);
        }
    }
}
