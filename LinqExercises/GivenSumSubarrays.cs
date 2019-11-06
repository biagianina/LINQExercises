using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExercises
{
    public class GivenSumSubarrays
    {
        readonly int[] numbers;
        readonly int k;

        public GivenSumSubarrays(int[] numbers, int k)
        {
            this.numbers = numbers;
            this.k = k;
        }

        public IEnumerable<int[]> GetSubarrayWithSumK()
        {
            return GetSubarrays(numbers).Where(c =>
            c.Aggregate((result, element) => result + element) <= k)
                .OrderBy(c => c.Count)
                .Select(x => x.ToArray());
        }

        public IEnumerable<ArraySegment<int>> GetSubarrays(int[] numbers)
        {
            return Enumerable.Range(0, numbers.Length)
                 .SelectMany(i => Enumerable.Range(0, numbers.Length - i)
                 .Select(j => new ArraySegment<int>(numbers, i, numbers.Length - i - j)));
        }
    }
}
