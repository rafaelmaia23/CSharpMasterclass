using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList.Collections
{
    public class Node<T>
    {
        public T? Value { get; }
        public Node<T>? Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString() =>
            $"Value: {Value}, Next: {(Next is null ? "null" : Next.Value)}";
    }
}
