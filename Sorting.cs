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

        public void InsertionSort()
        {

        }

        public void BubbleSort()
        {

        }

    }
}
