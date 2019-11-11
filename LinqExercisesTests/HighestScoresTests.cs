using System;
using System.Collections.Generic;
using Xunit;

namespace LinqExercises
{
    public class HighestScoresTests
    {
        [Fact]
        public void TestScores()
        {
            var andrei = new TestResults { Id = "Andrei", FamilyId = "Popescu", Score = 98 };
            var mihai = new TestResults { Id = "Mihai", FamilyId = "Popescu", Score = 100 };
            var ana = new TestResults { Id = "Ana", FamilyId = "Andreescu", Score = 56 };
            var diana = new TestResults { Id = "Diana", FamilyId = "Pop", Score = 78 };
            var gianina = new TestResults { Id = "Gianina", FamilyId = "Popescu", Score = 80 };
            var george = new TestResults { Id = "George", FamilyId = "Andreescu", Score = 20 };
            var ion = new TestResults { Id = "Ion", FamilyId = "Ionescu", Score = 85 };
            var marius = new TestResults { Id = "Marius", FamilyId = "Ionescu", Score = 98 };
            var families = new List<TestResults>
            {
                andrei,
                mihai,
                ana,
                diana,
                gianina,
                george,
                ion,
                marius
            };
            var result = new HighestScores(families).GetHighestScores();
            var expected = new List<TestResults>
            {
                mihai,
                ana,
                diana,
                marius
            };
            Assert.Equal(expected, result);
        }
    }
}
