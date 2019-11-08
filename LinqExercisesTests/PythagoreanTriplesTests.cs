using System;
using System.Collections.Generic;
using Xunit;

namespace LinqExercises
{
    public class PythagoreanTriplesTests
    {
        [Fact]
        public void OneTriplet()
        {
            var result = new PythagoreanTriples(new[] { 1, 2, 3, 4, 5 });
            var expected = new List<(int, int, int)> { (3, 4, 5) };
            Assert.Equal(expected, result.GetPythagoreanTriplets());
        }

        [Fact]
        public void MultipleTriplets()
        {
            var result = new PythagoreanTriples(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            var expected = new List<(int, int, int)>
            {
                (3, 4, 5),
                (5, 12, 13),
                (6, 8, 10),
                (8, 15, 17),
                (9, 12, 15),
                (12, 16, 20)
            };
            Assert.Equal(expected, result.GetPythagoreanTriplets());
        }

        [Fact]
        public void MultipleTripletsUnorderedArray()
        {
            var result = new PythagoreanTriples(new[] { 1, 2, 7, 6, 5, 4, 3, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
            var expected = new List<(int, int, int)>
            {
                (3, 4, 5),
                (5, 12, 13),
                (6, 8, 10),
                (8, 15, 17),
                (9, 12, 15),
                (12, 16, 20)
            };
            Assert.Equal(expected, result.GetPythagoreanTriplets());
        }
    }
}
