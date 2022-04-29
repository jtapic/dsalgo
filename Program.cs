using System;

namespace DSAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursion
            // Recursion r = new Recursion();
            // r.calculate(5);
            //  r.CalculateRecursion(4);

            // Sum of N 
            SumOfN s = new SumOfN();
            int sum = s.SumN(5);
            Console.WriteLine("Sum: "+ sum);
            sum = s.SumNIterative(10);
            Console.WriteLine("sum: "+ sum);
            sum =  s.SumNRecursion(15);
            Console.WriteLine("sum" + sum);
            
        } 
    }
}
