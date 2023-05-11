namespace AlberiListe
{
	internal class Program
	{
		class Nodo<Tipo> where Tipo : IComparable<Tipo>
		{
			public Tipo valore;
			public Nodo<Tipo> sx;
			public Nodo<Tipo> dx;
		}
		static void InserimentoValore<Tipo>(ref Nodo<Tipo> nodo, Tipo valore)
			 where Tipo : IComparable<Tipo>
		{
			while (nodo != null)
			{
				if (valore.CompareTo(nodo.valore) < 0)
					nodo = ref nodo.sx;
				else
					nodo = ref nodo.dx;
			}

			// Crea il nuovo nodo nel punto individuato
			nodo = new Nodo<Tipo>();
			nodo.valore = valore;
		}
		static void StampaElenco<Tipo>(Nodo<Tipo> nodo)
			 where Tipo : IComparable<Tipo>
		{
			if (nodo == null)
				return;

			StampaElenco(nodo.sx);
			Console.Write($"{nodo.valore}, ");
			StampaElenco(nodo.dx);
		}
		static void Main(string[] args)
		{
			Nodo<int> root = null;

			InserimentoValore(ref root, 8);
			InserimentoValore(ref root, 5);
			InserimentoValore(ref root, 10);
			InserimentoValore(ref root, 3);
			InserimentoValore(ref root, 6);
			InserimentoValore(ref root, 13);
			InserimentoValore(ref root, 9);

			StampaElenco(root);
		}
	}
}