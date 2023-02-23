namespace Esercizio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserire il numero di righe: ");
            int righe = int.Parse(Console.ReadLine());
            Console.Write("Inserire il numero di colonne: ");
            int colonne = int.Parse(Console.ReadLine());
            int[,] matrice = new int[righe, colonne];


            for (int f = 0; f < righe; f++)
                matrice[f,0] = f;

            for (int f = 1; f < colonne; f++)
                matrice[0,f] = f;

            for (int i = 1; i < righe; i++)
            {
                for (int j = 1; j < colonne; j++)
                {
                    matrice[i,j] = j * i;
                }
            }
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    Console.Write($"{matrice[i,j]} \t");
                }
                Console.WriteLine("");
            }

        }
    }
}