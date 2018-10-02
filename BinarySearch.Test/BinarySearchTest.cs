using Xunit;

namespace BinarySearch.Test
{
    public class BinarySearchTest
    {
        [Theory]
        [InlineData(45,12,32,45,56,74,69,71)]
        [InlineData(22, 11, 22, 33, 44, 55, 66, 77)]
        [InlineData(66, 2, 13, 34, 56, 61, 66, 71)]
        public void BinarySearchExtensionTest(int searchValue, params int[] array )
        {
            var index = array.BinarySearch(searchValue);
            Assert.True(index > 0);
        }
    }
}
