using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CourseProject
{
    public class DoublyLinkedList<T> : IEnumerable<T> 
    {
        private Node<T> _head;
        private Node<T> _tail;
        int count;

        public void Add(T element)
        {
            Node<T> node = new Node<T>(element);

            if (count == 0)
                _head = node;
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }

            _tail = node;
            count++;
        }

        public T RemoveFirst()
        {
            T output = _head.Element;
            if (count != 0)
            {
                _head = _head.Next;
                count--;

                if (count == 0)
                    _tail = null;
                else
                    _head.Previous = null;
            }
            return output;
        }

        public T RemoveLast()
        {
            T output = _tail.Element;
            if (count != 0)
            {
                if (count==1)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    _tail.Previous.Next = null;
                    _tail = _tail.Previous;
                }
            }

            count--;

            return output;
        }

        public bool Remove(T item)
        {
            Node<T> previous = null;
            Node<T> current = _head;

            while(current != null)
            {
                if (current.Element.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            _tail = previous;
                        else
                            current.Next.Previous = previous;

                        count--;
                    }
                    else
                        RemoveFirst();

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }
    }
}
