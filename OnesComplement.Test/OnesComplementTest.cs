using Xunit;

namespace OnesComplement.Test
{
    public class OnesComplementTest
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 0)]
        [InlineData(4, 3)]
        public void OnesComplementExtensionTest_SingleRun(int n, int expectedResult)
        {
            var result = n.OnesComplement();
            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(20)]
        public void OnesComplementExtensionTest_RunUntilOriginalNumber_Limit100Loops(int originalNumber) {
            // This is a test to see whether its possible - result is it is not
            var i = 0;
            var n = originalNumber;
            var matched = false;

            while (i < 100 && !matched) {
                var result = n.OnesComplement();
                if (result == originalNumber) matched = true;
                n = result;
                i++;
            }

            Assert.True(matched);
        }
    }
}
