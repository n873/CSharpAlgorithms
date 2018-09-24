using System.Collections.Generic;

namespace LinkedList
{
    public class CustomLinkedList
    {
        public CustomLinkedList() { }

        public CustomLinkedList(params int[] data)
        {
            foreach (var value in data)
                this.InsertFirst(value);
        }

        private Node first;

        public void InsertFirst(int data) {
            var newNode = new Node
            {
                Data = data,
                Next = first
            };
            first = newNode;
        }

        public Node DeleteFirst() {
            var temp = first;
            first = first.Next;
            return temp;
        }

        public List<string> GetList() {
            var list = new List<string>();
            var current = first;
            while (current != null) {
                list.Add(current.GetNode());
                current = current.Next;
            }
            return list;
        }

        public void InsertLast(int data) {
            var current = first;
            while (current.Next != null) current = current.Next;
            var newNode = new Node
            {
                Data = data
            };
            current.Next = newNode;
        }
    }
}
