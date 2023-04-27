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
		struct Coordinates
		{
			public int x;
			public int y;
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
			map[xTuna, yTuna] = map[xShark, yShark];
			map[xShark, yShark] = null;
		}
		static void PrintMap()
		{

		}
		static bool SharkSonar(int sight, Coordinates x_y)
		{
			int rangeHighY = sight - x_y.y;
			int rangeHighX = sight - x_y.x;
			int rangeLowX = sight + x_y.x;
			int rangeLowY = sight + x_y.y;
			bool entity = false;
			for (int i = rangeLowY; i < rangeHighY; i++)
				for (int j = rangeLowX; j < rangeHighX; j++)
					if (map[j, i] != null)
						if (map[j, i].type == Specimen.shark)
							entity = true;
			return entity;
		}
		static bool TunaSonar(int sight, Coordinates x_y)
		{
			int rangeHighY = sight - x_y.y;
			int rangeHighX = sight - x_y.x;
			int rangeLowX = sight + x_y.x;
			int rangeLowY = sight + x_y.y;
			bool entity = false;
			for (int i = rangeLowY; i < rangeHighY; i++)
				for (int j = rangeLowX; j < rangeHighX; j++)
					if (map[j, i] != null)
						if (map[j, i].type == Specimen.tuna)
							entity = true;
			return entity;
		}
		static Cell[] CreateMap(int xSize, int ySize, int numberOfCreatures)
		{
			map = new Cell[xSize, ySize];
			Random random = new Random();
			int[,] creaturesPosition = new int[2,numberOfCreatures];
			for (int i = 0; i < creaturesPosition.GetLength(0); i++)
			{
				for (int j = 0; j < creaturesPosition.GetLength(1); j++)
				{

				}
			}
			return null;
		}
		static void Turn()
		{
			for (int i = 0; i < map.GetLength(0); i++)
				for (int j = 0; i < map.GetLength(1); j++)
				{
					if (map[i, j] != null)
					{
						Coordinates coordinate = new Coordinates();
						coordinate.y = j; coordinate.x = i;
						if (map[i, j].type == Specimen.tuna)
							SharkSonar(TunaShark.tunaSight, coordinate);
						else if (map[i, j].type == Specimen.shark)
							TunaSonar(TunaShark.sharkSight, coordinate);
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