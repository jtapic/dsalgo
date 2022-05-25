using System;

namespace DSAlgorithms
{
    partial class Program
    {
        static void Main(string[] args )
        {
            //Circular Linked List
            
            CirLinkedLists cl = new CirLinkedLists();
            cl.CirAddLast(7);
            cl.CirAddLast(4);
            cl.CirAddLast(12);
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Size: "+cl.length());
            cl.CirAddLast(8);
            cl.CirAddLast(3);
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Size: "+cl.length());
            cl.CirAddFirst(25);
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Size: "+cl.length());
            cl.CirAddFirst(35);
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Size: "+cl.length());
            cl.CirAddAny(20,3);
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Size: "+cl.length());
            cl.CirAddAny(30,5);
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Size: "+cl.length());
            int element = cl.CirRemoveFirst();
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Removed Element "+ element);
            Console.WriteLine("Size: "+cl.length());
            element = cl.CirRemoveLast();
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Removed Element "+ element);
            Console.WriteLine("Size: "+cl.length());
            element = cl.CirRemoveAny(3);
            cl.DisplayCirLinkedLists();
            Console.WriteLine("Removed Element "+ element);
            Console.WriteLine("Size: "+cl.length());


            // Singly Linked List
            //LinkedLists l = new LinkedLists();
            //l.AddLast(7);
            //l.AddLast(4);
            //l.AddLast(12);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //l.AddLast(8);
            //l.AddLast(3);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //l.AddFirst(15);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //l.AddFirst(25);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //l.AddAny(20,3);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //int element = l.removeFirst();
            //Console.WriteLine("Removed Element: " + element);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //element = l.removeLast();
            //Console.WriteLine("Removed Element: " + element);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //element = l.removeAny(3);
            //Console.WriteLine("Removed Element: " + element);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: "+l.length());
            //int position = l.search(12);
            //Console.WriteLine("Result: " + position);
            //Console.WriteLine("Size: "+l.length());
            //l.insertSorted(7);
            //l.insertSorted(4);
            //l.insertSorted(12);
            //l.insertSorted(8);
            //l.insertSorted(3);
            //l.DisplayLinkedList();
            //Console.WriteLine("Size: " + l.length());



            //Sorting
            //var s = new Sorting();
            //int[] A = {3,5,8,9,6,2};
            //Console.WriteLine("Original Array:");  
            //s.Display(A);
            //s.SelectionSort(A);
            //s.InsertionSort(A);
            //s.BubbleSort(A);
            //s.ShellSort(A);
            //s.ShellSort2(A);
            // s.MergeSort(A,0,A.Length-1);
            //s.QuickSort(A,0,A.Length-1);
            //Console.WriteLine("Sorted Array:");
            //s.Display(A);

            //Binary Search
            //BinarySearch b = new BinarySearch();
            //int[] A = {15,21,47,84,96};
            //Console.WriteLine("Result:"+ b.BSearchIterative(A,96));
            //Console.WriteLine("Result:"+ b.BSearchRecursion(A,96,0,A.Length-1) );

            //Linear Search
            //LinearSearch s = new LinearSearch();
            //int[] A = {84,21,47,96,15};
            //int found = s.Search(A,A.Length,100);
            //Console.WriteLine("Result: "+found);

            //Factorial
            //Factorial f = new Factorial();
            //Console.WriteLine("Factorial: "+f.FactorialIterative(5));
            //Console.WriteLine("Factorial: "+f.FactorialRecursive(5));

            // Sum of N 
            //SumOfN s = new SumOfN();
            //int sum = s.SumN(5);
            //Console.WriteLine("Sum: "+ sum);
            //sum = s.SumNIterative(10);
            //Console.WriteLine("sum: "+ sum);
            //sum =  s.SumNRecursion(15);
            //Console.WriteLine("sum" + sum);

            // Recursion
            // Recursion r = new Recursion();
            // r.calculate(5);
            //  r.CalculateRecursion(4);



        }
    }
}
