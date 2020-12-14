using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject
{
    public class Node<T>
    {
        public Node(T element)
        {
            Element = element;
        }

        public T Element { get; set; }
        public  Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
    }
}
