using System;

namespace DSAlgorithms
{
    class Recursion
    {
        
        public void CalculateRecursion(int n)
        {
            if (n>0)
            {
                int k = n * n;
                Console.WriteLine(k);
                CalculateRecursion(n-1);

            }
        }
        public void calculate(int n)

        {
            for (int i=n;i>0;i--)
            {
                int j = i * i;
                Console.WriteLine(j);
               
            }
            Console.WriteLine();
             for (int i=1; i <= n; i++)
            {
               int h = i * i;
                Console.WriteLine(h);

            }
            Console.WriteLine();
            while (n>0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

    }
}
