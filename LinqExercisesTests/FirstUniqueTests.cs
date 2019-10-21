﻿using Xunit;

namespace LinqExercises
{
    public class FirstUniqueTests
    {
        [Fact]
        public void GetUniqueLetter()
        {
            var input = new FirstUnique("aaabbbcyydpp");
            Assert.Equal("c", input.GetFirstUnique());
        }

        [Fact]
        public void GetUniqueChar()
        {
            var input = new FirstUnique("a.aabbbcyydpp");
            Assert.Equal(".", input.GetFirstUnique());
        }

        [Fact]
        public void GetUniqueCharIgnoreCase()
        {
            var input = new FirstUnique("aaAbbbCcyydpp");
            Assert.Equal("d", input.GetFirstUnique());
        }
    }
}