using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList.Collections
{
    public interface ILinkedList<T> : ICollection<T>
    {
        void AddToFront(T item);
        void AddToBack(T item);
    }
}
