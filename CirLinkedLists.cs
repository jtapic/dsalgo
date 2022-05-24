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
