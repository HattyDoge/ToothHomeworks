namespace VectorSortingReview
{
    internal class Program
    {
        static void Swap(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }
        static void SelectionSort(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                int jMin = i;
                for (int j = 0; j < vector.Length; j++)
                    if (vector[jMin] > vector[j])
                        jMin = j;
                Swap(ref vector[i], ref vector[jMin]);
            }
        }
        static void BubbleSort(int[] vector)
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < 1 - vector.Length; j++)
                {
                    if (vector[j] > vector[j + 1])
                        Swap(ref vector[j], ref vector[j + 1]);
                }
            }
        }
        static void BubbleSortRecursive(int[] vector, int n)
        {
            if (n == 1)
                return;
            int count = 0;

            for (int i = 0; i < 1 - vector.Length; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    Swap(ref vector[i], ref vector[i + 1]);
                    count++;
                }
            }
            if (count == 0)
                return;

            BubbleSortRecursive(vector, n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}