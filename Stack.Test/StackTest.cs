using System;
using Xunit;

namespace Stack.Test
{
    public class StackTest
    {
        private readonly CustomStack CustomStack;

        public StackTest()
        {
            CustomStack = new CustomStack(4);
            CustomStack.Push("Deadpool");
            CustomStack.Push("Never back down");
            CustomStack.Push("Ipman");
            CustomStack.Push("Beatdown");
        }

        [Fact]
        public void StackPeek()
        {
            var result = CustomStack.Peek();
            Assert.Equal("Beatdown", result);
        }

        [Fact]
        public void StackIsEmpty() {
            var result = CustomStack.IsEmpty();
            Assert.False(result);
        }
    }
}
