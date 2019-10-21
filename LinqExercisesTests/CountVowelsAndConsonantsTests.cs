using Xunit;

namespace LinqExercises
{
    public class CountVowelsAndConsonantsTests
    {
        [Fact]
        public void VowelsAndConsonantNumber()
        {
            var text = new CountVowelsAndConsonants("ana are mere");
            Assert.Equal((6, 4), text.VowelsAndConsonantsCounter());
        }

        [Fact]
        public void VowelsAndConsonantNumberCaseInsensitive()
        {
            var text = new CountVowelsAndConsonants("Ana are Mere.");
            Assert.Equal((6, 4), text.VowelsAndConsonantsCounter());
        }
    }
}
