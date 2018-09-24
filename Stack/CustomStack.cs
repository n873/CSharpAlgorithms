using System;

namespace Stack
{
    public class CustomStack
    {
        private readonly int MaxSize;
        private readonly string[] StackArray;
        private int Top;

        public CustomStack(int size) {
            MaxSize = size;
            StackArray = new string[MaxSize];
            Top = -1;
        }

        public void Push(string m) {
            if (IsFull())
                throw new StackOverflowException("The stack is full");
            else {
                Top++;
                StackArray[Top] = m;
            }
        }

        public string Pop() {
            if (IsEmpty())
                throw new IndexOutOfRangeException("The stack is empty");
            else
            {
                var oldTop = Top;
                Top--;
                return StackArray[oldTop];
            }
        }

        public string Peek() => StackArray[Top];

        public bool IsEmpty() => Top == -1;

        private bool IsFull() => MaxSize - 1 == Top;
    }
}
