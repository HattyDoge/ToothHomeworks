namespace SimpleList
{
	internal class Program
	{
		class Nodo
		{
			public int valore;  // valore memorizzato
			public Nodo succ;    // riferimento al valore (nodo) successivo
		}
		class Lista
		{
			public Nodo testa;  // riferimento al primo elemento della lista
		}
		static void InserisciInTesta(Lista l, int valore)
		{
			Nodo nuovo_nodo = new Nodo();
			nuovo_nodo.valore = valore;

			// Il nuvo nodo va interposto fra .testa e quel che c'è dopo
			nuovo_nodo.succ = l.testa;
			l.testa = nuovo_nodo;
		}
		static void InserisciInCoda(Lista l, int valore)
		{
			// Si poszione sull'ultimo nodo
			ref Nodo nodo = ref l.testa;
			while (nodo != null)
				nodo = ref nodo.succ;

			// Crea il nuovo nodo alla posizione individuata
			nodo = new Nodo();
			nodo.valore = valore;
		}
		static int RicervaValore(Lista l, int valore_cercato)
		{
			int indice = 0;
			for (Nodo nodo = l.testa; nodo != null; nodo = nodo.succ, ++indice)
			{
				if (nodo.valore == valore_cercato)
					return indice;
			}

			return -1;  // Valore non presente
		}
		static bool EliminaValore(Lista l, int valore_cercato)
		{
			for (ref Nodo nodo = ref l.testa; nodo != null; nodo = ref nodo.succ)
			{
				if (nodo.valore == valore_cercato)
				{
					nodo = nodo.succ;  // elimina dalla catena dei .succ il nodo con .valore == valore_cercato
					return true;  // valore trovato ed eliminato
				}
			}

			return false;  // Valore non presente (e quindi non eliminato)
		}

		static void StampaLista(Lista l)
		{

			for (Nodo nodo = l.testa; nodo != null; nodo = nodo.succ)
			{
				if (nodo != l.testa)  // per tutti i nodi tranne il primo, aggiunge una virgola all'elenco
					Console.Write(", ");
				Console.Write(nodo.valore);
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			Lista l = new Lista();

			InserisciInCoda(l, 10);
			InserisciInCoda(l, 30);
			InserisciInCoda(l, 15);
			InserisciInCoda(l, 20);
			InserisciInCoda(l, 25);
			InserisciInCoda(l, 40);
			InserisciInCoda(l, 55);
			InserisciInCoda(l, 60);
			InserisciInCoda(l, 5);
			InserisciInCoda(l, 35);

			StampaLista(l);

			Console.WriteLine($"Ricerca 15 -> {RicervaValore(l, 15)}");
			Console.WriteLine($"Ricerca 75 -> {RicervaValore(l, 75)}");

			StampaLista(l);

			Console.WriteLine($"Elimina 20 -> {EliminaValore(l, 20)}");
			Console.WriteLine($"Elimina 75 -> {EliminaValore(l, 75)}");

			StampaLista(l);
		}
	}
}