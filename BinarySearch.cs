namespace DSAlgorithms
{
    public class BinarySearch
    {
        public int BSearchIterative(int[] A, int n, int key)
        {
            int l = 0;
            int r = n - 1;
            while (l<=r)
            {
                int mid = (l+r)/2;
                if(key == A[mid])
                    return mid;
                else if (key < A[mid])
                    r = mid - 1;
                else if (key > A[mid])
                    l = mid + 1;
            }
            return -1;
        }
    }
}
