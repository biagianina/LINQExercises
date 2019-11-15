using Xunit;

namespace LinqExercises
{
    public class RPNTests
    {
        [Fact]
        public void SumOperation()
        {
            var operation = new RPN("2 2 +");
            Assert.Equal(4, operation.Result());
        }

        [Fact]
        public void DifferenceOperation()
        {
            var operation = new RPN("4 2 -");
            Assert.Equal(2, operation.Result());
        }

        [Fact]
        public void ProductOperation()
        {
            var operation = new RPN("4 2 *");
            Assert.Equal(8, operation.Result());
        }

        [Fact]
        public void DivisionOperation()
        {
            var operation = new RPN("4 2 /");
            Assert.Equal(2, operation.Result());
        }

        [Fact]
        public void TwoOperators()
        {
            var operation = new RPN("2 1 1 + -");
            Assert.Equal(0, operation.Result());
        }

        [Fact]
        public void MultipleOperators()
        {
            var operation = new RPN("15 7 1 1 + - / 3 * 2 1 1 + + -");
            Assert.Equal(5, operation.Result());
        }
    }
}
