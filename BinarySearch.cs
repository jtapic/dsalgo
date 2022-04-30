namespace DSAlgorithms
{
    public class BinarySearch
    {
        public int BSearchRecursion(int[] A, int key, int l, int r)
        {
            if (l>r)
                return -1;
            else
            {
                int mid = (l+r)/2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    return BSearchRecursion(A,key,l,mid-1);
                else if (key > A[mid])
                    return BSearchRecursion(A,key,mid+1,r);
            }
            return -1;
        }
        public int BSearchIterative(int[] A, int key)
        {
            int l = 0;
            int r = A.Length - 1;
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
