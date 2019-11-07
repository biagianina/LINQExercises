using Xunit;

namespace LinqExercises
{
    public class SignsOrderTests
    {
        [Fact]
        public void OneGenerator()
        {
            var result = new SignsOrder(2, 3);
            Assert.Equal(new[] { "+1+2 = 3" }, result.GenerateEquations());
        }
    }
}
