using System;

namespace DSAlgorithms
{
    partial class Program
    {
        static void Main(string[] args )
        {

            LinearSearch s = new LinearSearch();
            int[] A = {84,21,47,96,15};
            int found = s.Search(A,A.Length,100);

            Console.WriteLine("Result: "+found);

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
