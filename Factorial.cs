namespace DSAlgorithms
{
    class Factorial
    {
        public int FactorialIterative(int n)
        {
            int fact = 1;
            for (int i = 1; i<= n; i++)
                 fact *= i;
            return fact;
        }

        public int FactorialRecursive(int n)
        {
            if(n == 0)
                return 1;
            return FactorialRecursive(n-1)*n;
        }
    }
}
