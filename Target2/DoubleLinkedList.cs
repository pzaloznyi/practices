using System.Collections;
using System.Collections.Generic;

namespace Target2
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_head == null)
                _head = node;
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }

            _tail = node;
            _count++;
        }

        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = _head;
            node.Next = temp;
            _head = node;
            if (_count == 0)
                _tail = _head;
            else
                temp.Previous = node;
            _count++;
        }

        public bool Remove(T data)
        {
            Node<T> current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }

                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    _tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    _head = current.Next;
                }

                _count--;
                return true;
            }

            return false;
        }

        public int Count => _count;
        public bool IsReadOnly { get; }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = _head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) this).GetEnumerator();
        }

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = _tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}