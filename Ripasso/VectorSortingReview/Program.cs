namespace VectorSortingReview
{
    internal class Program
    {
        struct Vectors
        {
            public int[] vett1;
            public int[] vett2;
            public int[] vett3;
        }
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
        static int[] FusionSortedMounting(int[] vettA, int[] vettB)
        {
            int[] vettF = new int[vettA.Length + vettB.Length];
            int iA = 0;
            int iB = 0;
            int i;
			for (i = 0; i < vettF.Length; i++)
            {
				if (vettA.Length <= iA || vettB.Length <= iB)
					break;
				if (vettA[iA] < vettB[iB])
                    vettF[i] = vettA[iA++];
				if (vettA.Length <= iA || vettB.Length <= iB)
					break;
				if (vettA[iA] >= vettB[iB])
                    vettF[i] = vettB[iB++];
            }
            while (vettA.Length > iA)
                vettF[i++] = vettA[iA++];

			while (vettB.Length > iB)
				vettF[i++] = vettB[iB++];

			return vettF;
		}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vectors vectorGroup = new Vectors();
            vectorGroup.vett1 = new int[2];
            vectorGroup.vett2 = new int[4];
            vectorGroup.vett1[0] = 2;
			vectorGroup.vett1[1] = 3;
            vectorGroup.vett2[0] = 4;
            vectorGroup.vett2[1] = 5;
            vectorGroup.vett2[2] = 6;
            vectorGroup.vett2[3] = 7;

			vectorGroup.vett3 = FusionSortedMounting(vectorGroup.vett1, vectorGroup.vett2);
            for(int i = 0; i < vectorGroup.vett3.Length; i++)
                Console.WriteLine(vectorGroup.vett3[i]);
        }
    }
}