using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExercises
{
    public class HighestScores
    {
        private readonly List<TestResults> families;

        public HighestScores(List<TestResults> families)
        {
            this.families = families;
        }

        public List<TestResults> GetHighestScores()
        {
            return families.GroupBy(x => x.FamilyId).Select(x => x.Aggregate(new TestResults(), (max, x) => x.Score > max.Score ? x : max)).ToList();
        }
    }
}
