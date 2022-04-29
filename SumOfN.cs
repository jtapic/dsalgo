namespace DSAlgorithms
{
    class SumOfN
    {
        public int SumN(int n)
        {
            return n * (n+1) / 2;
        }
         
        public int SumNIterative(int n)
        {
            int total = 0;
            for (int i = 1; i<=n;i++)
            {
                total += i;
            }
            return total;
        }
        public int SumNRecursion(int n)
        {
            if (n == 0)
                  return 0;
            return SumNRecursion(n-1)+n; 
        }
    }
}
