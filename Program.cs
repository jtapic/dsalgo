using System;

namespace DSAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
           // Recursion r = new Recursion();
            // r.calculate(5);
            //  r.CalculateRecursion(4);

            SumOfN s = new SumOfN();
            int sum = s.SumN(5);
            Console.WriteLine(sum);
            
        } 
    }
}
