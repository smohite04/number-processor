using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessor.Core.Models
{
    /// <summary>
    /// SingleAccessLinkedList is linear data structure with only one access point for entry and exit,
    /// i.e,data can enter and exit this list only from single point.
    /// </summary>
    /// <typeparam name="T">Type T is the type of data stored in this list</typeparam>
    internal class SingleAccessLinkedList<T>
    {
        /// <summary>
        /// The node expressing the access point for linkedList.
        /// At any point Tail defines last/latest node in linkedList.
        /// </summary>
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        public SingleAccessLinkedList()
        {
        }
        public SingleAccessLinkedList(IEnumerable<T> collection)
        {
            foreach (var value in collection)
            {
                AddLast(value);
            }
        }
        public void AddLast(T data)
        {
            var node = new Node<T>(data);

            if (Tail == null)
            {
                Tail = node;
            }
            else
            {
                node.Next = Tail;
                Tail = node;
            }
            Count++;
        }
        public T RemoveLast()
        {
            T data = Tail.Data;
            if (Tail == null)
            {
                throw new InvalidOperationException();
            }
            Tail = Tail.Next;
            Count--;
            return data;
        }
    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next {get; set;}
        public Node(T data)
        {
            Data = data;
            Next = null;
        }      
    }
}
