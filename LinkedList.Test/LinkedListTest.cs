using Xunit;

namespace LinkedList.Test
{
    public class LinkedListTest
    {
        private readonly CustomLinkedList customLinkedList;

        public LinkedListTest()
        {
            customLinkedList = new CustomLinkedList(
                100, 50, 99, 88, 999000);
        }

        [Fact]
        public void GetList()
        {
            var list = customLinkedList.GetList();
            Assert.Contains("100", list);
            Assert.Contains("50", list);
            Assert.Contains("99", list);
            Assert.Contains("88", list);
            Assert.Contains("999000", list);
        }

        [Fact]
        public void DeleteFirst() {
            customLinkedList.DeleteFirst();
            var list = customLinkedList.GetList();
            Assert.DoesNotContain("999000", list);  
        }
    }
}
