namespace DSAlgorithms
{
    partial class Program
    {
        public class LinearSearch
        {
            public int Search(int [] A, int n, int key)
            {
                for (int idx = 0;idx<n; idx++)
                {
                    if (A[idx]==key)
                        return idx;
                }
                
                return -1;
            }

        }
    }
}
