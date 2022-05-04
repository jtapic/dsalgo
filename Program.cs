﻿using System;

namespace DSAlgorithms
{
    partial class Program
    {
        static void Main(string[] args )
        {
            //Sorting
            var s = new Sorting();
            int[] A = {3,5,8,9,6,2};
            Console.WriteLine("Original Array:");  
            s.Display(A);
            //s.SelectionSort(A);
            //s.InsertionSort(A);
            //s.BubbleSort(A);
            //s.ShellSort(A);
            //s.ShellSort2(A);
            // s.MergeSort(A,0,A.Length-1);
            s.QuickSort(A,0,A.Length-1);
            Console.WriteLine("Sorted Array:");
            s.Display(A);



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
