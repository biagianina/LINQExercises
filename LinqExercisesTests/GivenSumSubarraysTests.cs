using System;
using System.Collections.Generic;
using Xunit;

namespace LinqExercises
{
    public class GivenSumSubarraysTests
    {
        [Fact]
        public void Subarrays()
        {
            var input = new GivenSumSubarrays(new[] { 1, 2, 3, 4, 5, 6 }, 6);
            var result = new List<string>
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "1 2",
                "2 3",
                "1 2 3"
            };
            Assert.Equal(result, input.GetSubarrayWithSumK());
        }
    }
}
