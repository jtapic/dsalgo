using System;
namespace DSAlgorithms
{
    public class CirLinkedLists
    {
        private Node head;
        private Node tail;
        private int size;

        public CirLinkedLists()
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

        public void CirAddLast(int e)
        {
            Node newest = new Node(e,null);
            if (IsEmpty())
            {
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }
            tail = newest;
            size += 1;
        }

        public void CirAddFirst(int e)
        {
            Node newest = new Node(e,null);
            if (IsEmpty())
            {
                newest.next = newest;
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.next = head;
                head = newest;
            }
            size +=1;
        }

        public void CirAddAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e,null);
            Node p = head;
            int i = 1;
            while (i < position -1)
            {
                p = p.next;
                i += 1;
            }
            newest.next = p.next;
            p.next = newest;
            size +=1;
        }

        public int CirRemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Circular List is Empty");
                return -1;
            }
            int e = head.element;
            tail.next = head.next;
            head = head.next;
            size = size -1 ;
            if (IsEmpty())
            {
                head = null;
                tail = null;
            }
            return e;

        }

        public void DisplayCirLinkedLists()
        {
            Node p = head;
            int i = 0;
            while (i<length())
            {
                Console.Write(p.element+"-->");
                p = p.next;
                i += 1;
            }
            Console.WriteLine();
        }
    }
}
