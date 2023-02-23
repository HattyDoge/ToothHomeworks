namespace EserciziMatrici
{
	internal class Program
	{
		static double MediaClasse(int[,] tabellone)
		{
			int somma = 0;
			for (int i = 0; i < tabellone.GetLength(0); i++)
				for (int j = 0; j < tabellone.GetLength(1); j++)
					somma += tabellone[i, j];
			return somma / (double)tabellone.Length;
		}

		static void MediaMigliore(string[] nomi, string[] materie, int[,] tabellone)
		{
			int indicePersona = 0;
			double mediaMigliore = 0;
			for (int i = 0; i < tabellone.GetLength(0); i++)
			{
				int somma = 0;
				for (int j = 0; j < tabellone.GetLength(1); j++)
					somma += tabellone[i, j];

				double media = (double)somma / materie.Length;
				if (media > mediaMigliore)
				{
					indicePersona = i;
					mediaMigliore = media;
				}

			}
			Console.WriteLine($"Lo studente con la media migliore è {nomi[indicePersona]} con media {mediaMigliore}");
		}

		static void AlunnoInsufficiente(string[] nomi, string[] materie, int[,] tabellone)
		{
			int indicePersona = 0;
			Console.WriteLine("Inserire il nome della studente");
			string nome = Console.ReadLine();
			bool nomeTrovato = false;
			for (int i = 0; i < nomi.Length; i++)
				if (nome == nomi[i])
				{
					indicePersona = i;
					nomeTrovato = true;
					break;
				}
			if (!nomeTrovato)
			{
				Console.WriteLine($"{nome} non è stato trovato nell'elenco"); return;
			}

			for (int j = 0; j < tabellone.GetLength(1); j++)
				if (tabellone[indicePersona, j] < 6)
					Console.WriteLine($"{materie[j]} {tabellone[indicePersona, j]}");
		}

		static void MediaMateria(string[] materie, int[,] tabellone)
		{
			int indiceMateria = 0;
			Console.WriteLine("Inserire il nome della materia");
			string materia = Console.ReadLine();
			bool materiaTrovata = false;
			for (int j = 0; j < materie.Length; j++) 
			{
				if (materia == materie[j])
				{
					indiceMateria = j;
					materiaTrovata = true;
					break;
				}
			}
			if (!materiaTrovata)
			{
				Console.WriteLine($"{materia} non è stato trovato nell'elenco"); return;
			}
			
			int somma = 0;
			for (int i = 0; i < tabellone.GetLength(1); i++)
				somma += tabellone[i, indiceMateria];
			double media = somma / (double)tabellone.GetLength(0);
			Console.WriteLine($"La media della materia {materia} è {media}");
		}
		static int MateriaPiùInsufficienti(string[] nomi, string[] materie, int[,] tabellone)
		{
			int[] nInsufficenti = new int[materie.Length];
			for (int j = 0; j < tabellone.GetLength(1); j++)
				for(int i = 0; i < tabellone.GetLength(0);i++ )
				{
					if (tabellone[i, j] < 6)
						nInsufficenti[j]++;
				}
			int materiaPiùInsufficiente = 0;
			int piùInsufficienti = -1;
			for (int i = 0; i < nInsufficenti.Length; i++)
				if (nInsufficenti[i] > piùInsufficienti)
				{
					materiaPiùInsufficiente = i;
					piùInsufficienti = nInsufficenti[i];
				}
			return materiaPiùInsufficiente;
		}

		static void Main(string[] args)
		{
			int N = 14;
			int M = 10;
			//string[] nomi = new string[N];
			//string[] materie = new string[M];
			//int[,] tabellone = new int[N, M];

			int[,] tabella = new int[N, M];
			string[] materie = new string[M];
			string[] nomi = new string[N];


			materie[0] = "italiano";
			materie[1] = "storia";
			materie[2] = "matematica";
			materie[3] = "inglese";
			materie[4] = "informatica";
			materie[5] = "tpsit";
			materie[6] = "telecomunicazione";
			materie[7] = "sistemi e reti";
			materie[8] = "motoria";
			materie[9] = "religione";

			nomi[0] = "CRISTIAN";
			nomi[1] = "ANDREA";
			nomi[2] = "GIUSEPPE";
			nomi[3] = "MAURO";
			nomi[4] = "MATTIA";
			nomi[5] = "MARCO";
			nomi[6] = "MANFREDI";
			nomi[7] = "RICCARDO";
			nomi[8] = "GABRIELE";
			nomi[9] = "EDOARDO";
			nomi[10] = "FILIPPO";
			nomi[11] = "FEDERICO";
			nomi[12] = "SIMONE";
			nomi[13] = "GIORGIO";
			// CRISIAN
			tabella[0, 0] = 9;
			tabella[0, 1] = 8;
			tabella[0, 2] = 7;
			tabella[0, 3] = 8;
			tabella[0, 4] = 7;
			tabella[0, 5] = 7;
			tabella[0, 6] = 6;
			tabella[0, 7] = 5;
			tabella[0, 8] = 9;
			tabella[0, 9] = 9;

			// ANDREA
			tabella[1, 0] = 7;
			tabella[1, 1] = 6;
			tabella[1, 2] = 8;
			tabella[1, 3] = 6;
			tabella[1, 4] = 8;
			tabella[1, 5] = 6;
			tabella[1, 6] = 6;
			tabella[1, 7] = 6;
			tabella[1, 8] = 9;
			tabella[1, 9] = 9;

			// GIUSEPPE
			tabella[2, 0] = 5;
			tabella[2, 1] = 6;
			tabella[2, 2] = 5;
			tabella[2, 3] = 7;
			tabella[2, 4] = 4;
			tabella[2, 5] = 6;
			tabella[2, 6] = 7;
			tabella[2, 7] = 7;
			tabella[2, 8] = 8;
			tabella[2, 9] = 9;

			// MAURO
			tabella[3, 0] = 6;
			tabella[3, 1] = 6;
			tabella[3, 2] = 4;
			tabella[3, 3] = 4;
			tabella[3, 4] = 6;
			tabella[3, 5] = 6;
			tabella[3, 6] = 8;
			tabella[3, 7] = 7;
			tabella[3, 8] = 7;
			tabella[3, 9] = 9;

			// MATTIA
			tabella[4, 0] = 5;
			tabella[4, 1] = 5;
			tabella[4, 2] = 6;
			tabella[4, 3] = 5;
			tabella[4, 4] = 8;
			tabella[4, 5] = 5;
			tabella[4, 6] = 6;
			tabella[4, 7] = 6;
			tabella[4, 8] = 8;
			tabella[4, 9] = 9;

			// MARCO
			tabella[5, 0] = 8;
			tabella[5, 1] = 7;
			tabella[5, 2] = 4;
			tabella[5, 3] = 7;
			tabella[5, 4] = 7;
			tabella[5, 5] = 4;
			tabella[5, 6] = 6;
			tabella[5, 7] = 5;
			tabella[5, 8] = 9;
			tabella[5, 9] = 9;

			// MANFREDI
			tabella[6, 0] = 6;
			tabella[6, 1] = 8;
			tabella[6, 2] = 7;
			tabella[6, 3] = 8;
			tabella[6, 4] = 7;
			tabella[6, 5] = 4;
			tabella[6, 6] = 9;
			tabella[6, 7] = 4;
			tabella[6, 8] = 8;
			tabella[6, 9] = 9;

			// RICCARDO
			tabella[7, 0] = 6;
			tabella[7, 1] = 6;
			tabella[7, 2] = 8;
			tabella[7, 3] = 4;
			tabella[7, 4] = 7;
			tabella[7, 5] = 6;
			tabella[7, 6] = 8;
			tabella[7, 7] = 4;
			tabella[7, 8] = 8;
			tabella[7, 9] = 0;

			// GABRIELE
			tabella[8, 0] = 7;
			tabella[8, 1] = 7;
			tabella[8, 2] = 6;
			tabella[8, 3] = 5;
			tabella[8, 4] = 5;
			tabella[8, 5] = 7;
			tabella[8, 6] = 6;
			tabella[8, 7] = 5;
			tabella[8, 8] = 9;
			tabella[8, 9] = 9;

			// EDOARDO
			tabella[9, 0] = 4;
			tabella[9, 1] = 6;
			tabella[9, 2] = 6;
			tabella[9, 3] = 7;
			tabella[9, 4] = 6;
			tabella[9, 5] = 8;
			tabella[9, 6] = 6;
			tabella[9, 7] = 7;
			tabella[9, 8] = 7;
			tabella[9, 9] = 9;

			// FILIPPO
			tabella[10, 0] = 6;
			tabella[10, 1] = 7;
			tabella[10, 2] = 5;
			tabella[10, 3] = 7;
			tabella[10, 4] = 6;
			tabella[10, 5] = 6;
			tabella[10, 6] = 6;
			tabella[10, 7] = 6;
			tabella[10, 8] = 9;
			tabella[10, 9] = 9;

			// FEDERICO
			tabella[11, 0] = 9;
			tabella[11, 1] = 7;
			tabella[11, 2] = 5;
			tabella[11, 3] = 6;
			tabella[11, 4] = 7;
			tabella[11, 5] = 7;
			tabella[11, 6] = 6;
			tabella[11, 7] = 6;
			tabella[11, 8] = 8;
			tabella[11, 9] = 9;

			// SIMONE
			tabella[12, 0] = 5;
			tabella[12, 1] = 4;
			tabella[12, 2] = 7;		
			tabella[12, 3] = 7;
			tabella[12, 4] = 9;
			tabella[12, 5] = 6;
			tabella[12, 6] = 5;
			tabella[12, 7] = 6;
			tabella[12, 8] = 8;
			tabella[12, 9] = 9;

			// GIORGIO
			tabella[13, 0] = 6;
			tabella[13, 1] = 6;
			tabella[13, 2] = 8;
			tabella[13, 3] = 8;
			tabella[13, 4] = 7;
			tabella[13, 5] = 5;
			tabella[13, 6] = 6;
			tabella[13, 7] = 5;
			tabella[13, 8] = 9;
			tabella[13, 9] = 9;
			MediaMateria(materie, tabella);
			Console.WriteLine($"Media totale classe {MediaClasse(tabella)}");
			AlunnoInsufficiente(nomi, materie, tabella);
			MediaMigliore(nomi, materie, tabella);
			MateriaPiùInsufficienti(nomi, materie, tabella);
		}
	}
}
