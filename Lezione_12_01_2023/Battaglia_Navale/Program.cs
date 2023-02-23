namespace Battaglia_Navale
{
    internal class Program
    {
        static bool[,] GeneraTabellaNemici(int righe, int colonne)
        {
            bool[,] tabellaNemici = new bool[righe, colonne];
            Random rnd = new Random();
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    int possibilitàNemico = rnd.Next(10 + 1);
                    tabellaNemici[i, j] = false;
                    if (possibilitàNemico == 10)
                    {
                        tabellaNemici[i, j] = true;
                    }
                }
            }
            return tabellaNemici;
        }
        static bool[,] GeneraTabellaGiocatore(int righe, int colonne)
        {
            bool[,] tabellaGiocatore = new bool[righe, colonne];
            Random rnd = new Random();
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    tabellaGiocatore[i, j] = false;
                }
            }
            return tabellaGiocatore;
        }
        static void StampaTabellaNemici(int righe, int colonne, string postoVuoto, string postoPieno, bool[,] tabellaNemici)
        {
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    if (tabellaNemici[i, j] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(postoPieno + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(postoVuoto + " ");
                }
                Console.WriteLine();
            }
        }
        static void GeneraTabellaGiocatore(int righe, int colonne, string postoVuoto, string postoColpito, bool[,] tabellaGiocatore)
        {
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                    if (tabellaGiocatore[i, j] == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(postoColpito + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(postoVuoto + " ");
                }
                Console.WriteLine();
            }
        }
        static void SceltaNemico(bool[,] tabellaNemici, bool[,] tabellaGiocatore)
        {

            Console.WriteLine("Inserire la riga");
            int riga = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la colonna");
            int colonna = int.Parse(Console.ReadLine());
            if (tabellaNemici[riga,colonna] == true)
            {
                tabellaGiocatore[riga,colonna] = true;
                Console.WriteLine("Colpito !");
            }
            else
            { Console.WriteLine("Mancato"); }
        }
        static void Main(string[] args)
        {
            int colonne = 10, righe = 10;
            bool[,] tabellaNemici = GeneraTabellaNemici(righe, colonne);
            bool[,] tabellaGiocatore = GeneraTabellaGiocatore(righe, colonne);
            string postoVuoto = "\x01";
            string postoPieno = "\x02";
            string postoColpito = "\x0F";


        }
    }
}