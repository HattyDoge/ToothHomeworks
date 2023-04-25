namespace TunaAndSharks
{
	internal class Program
	{
		enum Type
		{
			shark,
			tuna
		}
		class Shark { }
		class Tuna { }
		
		class Cell
		{
			public Type type;
			public Shark shark;
			public Tuna tuna;
		}
		static void PrintMap()
		{

		}
		static Cell CreateShark()
		{
			Cell cell = new Cell();
			cell.type = Type.shark;
			return cell;
		}
		static Cell CreateTuna()
		{
			Cell cell = new Cell();
			cell.type = Type.tuna;
			return cell;
		}
		static Cell[] CreateMap(int xSize, int ySize)
		{
			return null;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
}