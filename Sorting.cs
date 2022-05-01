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
