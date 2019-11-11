using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LinqExercises
{
    public class TestResults : IEqualityComparer<TestResults>
    {
        public string Id { get; set; }

        public string FamilyId { get; set; }

        public int Score { get; set; }

        public bool Equals(TestResults x, TestResults y)
        {
            return x.FamilyId.Equals(y.FamilyId) &&
                x.Id.Equals(y.Id) &&
                x.Score.Equals(y.Score);
        }

        public int GetHashCode(TestResults obj)
        {
            return obj.GetHashCode();
        }
    }
}
