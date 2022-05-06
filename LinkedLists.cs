using System;
namespace DSAlgorithms
{
    public class LinkedLists
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkedLists()
        {
            head = null;
            tail = null;
            size = 0;

        }
        public int length()
        {
            return size;
        }


        public bool IsEmpty()
        {
            return size == 0;
        }
        
        public void AddLast(int e)
        {
            Node newest = new Node(e,null);
            if (IsEmpty())
            {
                head = newest;
            }
            else
            {
                tail.next = newest;
            }
            tail = newest;
            size += 1;
        }

        public void DisplayLinkedList()
        {
            Node p = head;
            while(p != null)
            {
                Console.Write(p.element + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }
}
