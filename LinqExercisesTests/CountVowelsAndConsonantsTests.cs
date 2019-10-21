using Xunit;

namespace LinqExercises
{
    public class CountVowelsAndConsonantsTests
    {
        [Fact]
        public void VowelsNumber()
        {
            var text = new CountVowelsAndConsonants("ana are mere");
            Assert.Equal((6, 4), text.VowelsAndConsonantsCounter());
        }
    }
}
