namespace TreesAndLists
{
	internal class Program
	{
		class Node
		{
			public int value;  // valore memorizzato
			public Node succ;    // riferimento al valore (nodo) successivo
		}
		class List
		{
			public Node testa;  // riferimento al primo elemento della lista
		}
		static int CountValuesList(List l)
		{
			Node nodesucc = l.testa;
			int count = 0;
			while (nodesucc.succ != null)
			{
				if (nodesucc.value != null)
					count++;
				nodesucc = nodesucc.succ;
			}
			return count;
		}
		static void CountValuesTree()
		{

		}
		static void DeleteValueList(List l, int value)
		{
			for (ref Node nodo = ref l.testa; nodo != null; nodo = ref nodo.succ)
			{
				if (nodo.value == value)
				{
					nodo = nodo.succ; 
				}
			}
		}
		static void NewNode(List l, int valore)
		{
			ref Node nodo = ref l.testa;
			while (nodo != null)
				nodo = ref nodo.succ;
			nodo = new Node();
			nodo.value = valore;
		}
		static void Main(string[] args)
		{
			List l = new List();
			NewNode(l, 1);
			NewNode(l, 10);
			NewNode(l, 1);
			NewNode(l, 1);
			NewNode(l, 10);
			NewNode(l, 1);
			NewNode(l, 2);
			DeleteValueList(l, 10);
		}
	}
}