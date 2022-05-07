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

        public void AddFirst(int e)
        {
            Node newest = new Node(e,null);
            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size += 1;
        }

        public void AddAny(int e, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while(i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next = newest;
            size = size + 1;
        }

        public int removeFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                size = size - 1;
                if (IsEmpty())
                {
                    tail = null;
                }
                return e;
            }
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
