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
            public int Search2(int[] A, int n, int key)
            {
                int index = 0;
                while(index < n)
                {
                    if (A[index]==key)
                        return index;
                    index ++;
                }
                return -1;
            }
        }
    }
}
