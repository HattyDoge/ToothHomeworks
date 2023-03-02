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

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}