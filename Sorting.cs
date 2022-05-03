using System; 
namespace DSAlgorithms
{
    public class Sorting
    {
        public void Display(int[] A)
        {
            for (int i = 0;i<A.Length;i++)
            {
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();
        }

        public void MergeSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right)/2;
                MergeSort(A,left,mid);
                MergeSort(A,mid + 1,right);
                Merge(A,left,mid,right);
            }

        }
        
        public void Merge(int[] A, int left, int mid, int right )
        {
            int i = left;
            int j = mid +1;
            int k = left;
            int [] B = new int[right+1];
            while(i <= mid && j <= right)
            {
                if (A[i] < A[j])
                {
                    B[k] = A[i];
                    i = i + 1;
                }
                else
                {
                    B[k] = A[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            while (i <= mid)
            {
                B[k] = A[i];
                i = i +1;
                k = k + 1;
            }
            while(j <= right)
            {
                B[k] = A[j];
                j = j + 1;
                k = k + 1;
            }
            for (int x = left; x < right + 1; x++)
            {
                A[x] = B[x];
            }
        }

        public void ShellSort(int[] A)
        {
            int n = A.Length;
            int gap = n/2;
            while (gap > 0)
            {
                int i = gap;
                while (i < n)
                {
                    int temp = A[i];
                    int j = i-gap;
                    while (j >= 0 && A[j] > temp)
                    {
                        A[j+gap] = A[j];
                        j = j-gap;
                    }
                    A[j+gap] = temp;
                    i = i+1;
                }
                gap = gap/2;
            }


        }
        public void ShellSort2(int[] A)
        {
            int n = A.Length;
            for (int gap = n/2; gap > 0; gap = gap/2)
            {
                for (int i = gap ; i < n; i++)
                {
                    int gvalue = A[i];
                    int j = i-gap;
                    while (j >= 0 && A[j] > gvalue)
                    {
                        A[j+gap] = A[j];
                        j = j-gap;
                    }
                    A[j+gap] = gvalue;
                }
            }
        }


        public void BubbleSort(int[] A)
        {
            for (int pass = A.Length-1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass ; i++)
                {
                    if (A[i] > A[i+1])
                    {
                        int temp = A[i];
                        A[i] = A[i+1];
                        A[i+1] = temp;
                    }
                }
            }

        }


        public void InsertionSort(int [] A)
        {
            for (int i = 1; i<A.Length;i++)
            {
                int temp = A[i];
                int position = i;
                while (position > 0 && A[position-1] > temp)
                {
                    A[position] = A[position-1];
                    position = position - 1;
                }
                A[position] = temp;
            }

        }

 

        public void SelectionSort(int[] A)
        {
            for (int i = 0; i < A.Length -1;i++)
            {
                int position = i;
                for (int j = i+1;j<A.Length;j++)
                {
                    if (A[j] < A[position])
                        position = j;
                    int temp = A[i];
                    A[i] = A[position];
                    A[position] = temp;
                }
            }
        } 

       


    }
}
