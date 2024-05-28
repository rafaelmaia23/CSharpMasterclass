using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList.Collections
{
    public class CustomLinkedList<T> : ILinkedList<T?>
    {
        private Node<T>? _head;

        private int _count;
        public int Count => _count;

        public bool IsReadOnly => false;

        public void Add(T? item)
        {
            AddToBack(item);
        }

        public void AddToBack(T? item)
        {
            var newNode = new Node<T>(item);
            if(_head is null) 
            {
                _head = newNode;
            }
            else
            {
                var tail = GetNodes().Last();
                tail.Next = newNode;
            }
            ++_count;
        }

        public void AddToFront(T? item)
        {
            var newHead = new Node<T>(item)
            {
                Next = _head
            };
            _head = newHead;
            ++_count;
        }

        public void Clear()
        {
            Node<T>? current = _head;
            while(current is not null)
            {
                Node<T>? temporary = current;
                current = current.Next;
                temporary.Next = null;
            }
            _head = null;
            _count = 0;
        }

        public bool Contains(T? item)
        {
            if(item is null)
            {
                return GetNodes().Any(node => node.Value is null);
            }
            return GetNodes().Any(node => item.Equals(node.Value));
        }

        public void CopyTo(T?[] array, int arrayIndex)
        {
            if(array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if(arrayIndex < 0 || arrayIndex >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            }
            if(array.Length < _count + arrayIndex)
            {
                throw new ArgumentException("Array is not long enough");
            }
            foreach(var node in GetNodes())
            {
                array[arrayIndex] = node.Value;
                ++arrayIndex;
            }
        }        

        public bool Remove(T? item)
        {
            Node<T>? predecessor = null;
            foreach(var node in GetNodes())
            {
                if((node.Value is null && item is null) ||
                    (node.Value is not null && node.Value.Equals(item)))
                {
                    if(predecessor is null)
                    {
                        _head = node.Next;
                    }
                    else
                    {
                        predecessor.Next = node.Next;
                    }
                    --_count;
                    return true;
                }
                predecessor = node;
            }
            return false;
        }

        public IEnumerator<T?> GetEnumerator()
        {
            foreach(var node in GetNodes())
            {
                yield return node.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<Node<T>> GetNodes()
        {
            Node<T>? current = _head;
            while(current is not null)
            {
                yield return current;
                current = current.Next;
            }
        }


        //public Node<T>? Head { get; set; }
        //public Node<T>? Tail { get; set; }
        //private int _count = 0;

        //public int Count => _count;

        //public bool IsReadOnly => false;

        //public void Add(T item)
        //{
        //    var node = new Node<T>(item);
        //    if(Head == null)
        //    {
        //        Head = node;
        //    }
        //    if(Tail != null)
        //    {
        //        Tail.Next = node;
        //    }
        //    Tail = node;
        //    _count++;
        //}

        //public void AddToBack(T item)
        //{
        //    Add(item);
        //}

        //public void AddToFront(T item)
        //{
        //    var node = new Node<T>(item);
        //    if(Head != null)
        //    {
        //        node.Next = Head;
        //    }
        //    Head = node;
        //    _count++;
        //}

        //public void Clear()
        //{
        //    Head = null;
        //    Tail = null;
        //    _count = 0;
        //}

        //public bool Contains(T item)
        //{
        //    var currentNode = Head;
        //    for(int i = 0; i < _count; i++)
        //    {
        //        if (currentNode.Value.Equals(item))
        //        {
        //            return true;
        //        }
        //        currentNode = currentNode.Next;
        //    }
        //    return false;            
        //}

        //public void CopyTo(T[] array, int arrayIndex)
        //{
        //    var currentNode = Head;
        //    for (int i = 0; i < arrayIndex; ++i)
        //    {
        //        currentNode = currentNode.Next;
        //    }
        //    int index = 0;
        //    while (currentNode != null)
        //    {
        //        array[index] = currentNode.Value;
        //        currentNode = currentNode.Next;
        //    }
        //}

        //public IEnumerator<T> GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Remove(T item)
        //{
        //    var currentNode = Head;
        //    Node<T>? preNode = null;
        //    for(int i = 0; i< _count; i++)
        //    {
        //        if(currentNode.Value.Equals(item))
        //        {
        //            if(currentNode == Head)
        //            {
        //                Head = currentNode.Next;
        //            }
        //            else
        //            {
        //                preNode.Next = currentNode.Next;
        //            }
        //            if(currentNode == Tail)
        //            {
        //                Tail = preNode;
        //                Tail.Next = null;
        //            }
        //            _count--;
        //            return true;                    
        //        }
        //        preNode = currentNode;
        //        currentNode = currentNode.Next;
        //    }
        //    return false;
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
