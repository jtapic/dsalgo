using System;

namespace DSAlgorithms
{
    class Recursion
    {
        public void calculate(int n)

        {

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
