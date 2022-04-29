using System;

namespace DSAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //Factorial
            Factorial f = new Factorial();
            Console.WriteLine("Factorial: "+f.FactorialIterative(5));
            Console.WriteLine("Factorial: "+f.FactorialRecursive(5));


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
