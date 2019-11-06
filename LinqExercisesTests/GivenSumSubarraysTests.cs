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
            var result = new List<int[]>
            {
                new[] { 1 },
                new[] { 2 },
                new[] { 3 },
                new[] { 4 },
                new[] { 5 },
                new[] { 6 },
                new[] { 1, 2 },
                new[] { 2, 3 },
                new[] { 1, 2, 3 }
            };
            Assert.Equal(result, input.GetSubarrayWithSumK());
        }
    }
}
