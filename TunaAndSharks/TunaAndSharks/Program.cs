using System.Security.Cryptography.X509Certificates;

namespace TunaAndSharks
{
	internal class Program
	{
		struct SpecimenInfo
		{
			public int tunaReproductionLowerRange;
			public int tunaReproductionBiggerRange;
			public int sharkDeath;
			public int sharkSight;
			public int tunaSight;
			public int numberOfTunas;
			public int numberOfSharks;
		}
		static SpecimenInfo TunaShark = new SpecimenInfo();

		static Cell[,] map;
		enum Specimen
		{
			shark,
			tuna
		}
		class Shark 
		{
			public bool digestion;
			public int digestionCounter;
			public int deathCounter;
		}
		class Tuna 
		{
			public bool reproductionAvailable;
			public bool reproductionActive;
			public int reproductionWait;
			public int reproductionCycle;
		}
		class Cell
		{
			public Specimen type;
			public Shark shark;
			public Tuna tuna;
		}

		static Cell CreateShark()
		{
			Cell cell = new Cell();
			cell.type = Specimen.shark;

			Shark shark = new Shark();
			shark.digestion = false;
			shark.deathCounter = 1;
			shark.digestionCounter = 1;

			cell.shark = shark;

			return cell;
		}
		static Cell CreateTuna()
		{
			Cell cell = new Cell();
			cell.type = Specimen.tuna;

			Tuna tuna = new Tuna();
			tuna.reproductionWait = 1;
			tuna.reproductionAvailable = false;
			tuna.reproductionActive = false;
			tuna.reproductionCycle = 1;

			cell.tuna = tuna;

			return cell;
		}
		static void EatTuna(int xShark, int yShark, int xTuna, int yTuna)
		{

		}

		static void PrintMap()
		{

		}
		static Cell[] CreateMap(int xSize, int ySize)
		{
			map = new Cell[xSize, ySize];
			return null;
		}
		static void Turn()
		{
			for (int i = 0; i < map.GetLength(0); i++)
				for (int j = 0; i < map.GetLength(0); j++)
				{
					if (map[i, j] != null)
					{

					}
				}
		}
		static void Main(string[] args)
		{
			int ySize = 100;
			int xSize = 100;
			TunaShark.numberOfSharks = (ySize * xSize * 5) / 100;
			TunaShark.numberOfTunas = (ySize * xSize * 10) / 100;
			TunaShark.tunaSight = 5;
			TunaShark.sharkDeath = 11;
			TunaShark.sharkSight = 3;
			TunaShark.tunaReproductionLowerRange = 6;
			TunaShark.tunaReproductionBiggerRange = 10;


		}
	}
}