using System;
using Xunit;

namespace LinqExercises
{
    public class ConvertStringToIntegerTests
    {
        [Fact]
        public void SingleCharacterStringToInteger()
        {
            var input = new ConvertStringToInteger("9");
            Assert.Equal(9, input.GetIntegerValue());
        }

        [Fact]
        public void TwoCharactersStringToInteger()
        {
            var input = new ConvertStringToInteger("97");
            Assert.Equal(97, input.GetIntegerValue());
        }

        [Fact]
        public void NegativeStringToInteger()
        {
            var input = new ConvertStringToInteger("-5897");
            Assert.Equal(-5897, input.GetIntegerValue());
        }

        [Fact]
        public void StringStartingWithZero()
        {
            var input = new ConvertStringToInteger("0897");
            Assert.Equal(897, input.GetIntegerValue());
        }

        [Fact]
        public void StringContainingLetter()
        {
            var input = new ConvertStringToInteger("a897");
            Assert.Throws<ArgumentException>(() => input.GetIntegerValue());
        }
    }
}
