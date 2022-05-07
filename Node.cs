using System;

namespace DSAlgorithms
{
    public class Node
    {
        public int element {get;set;}
        public Node next {get;set;}
        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }
}
