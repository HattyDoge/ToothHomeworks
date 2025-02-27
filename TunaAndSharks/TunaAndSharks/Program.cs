﻿using System.Security.Cryptography.X509Certificates;

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
			tuna.reproductionWait = 1; //attesa per la nascita
			tuna.reproductionAvailable = false;
			tuna.reproductionActive = false;
			tuna.reproductionCycle = 1; //attesa per la riproduzione

			cell.tuna = tuna;

			return cell;
		}
		static void EatTuna(Coordinates Shark, Coordinates Tuna)
		{
			var yShark = Shark.y;
			var xShark = Shark.x;
			var yTuna = Tuna.y;
			var xTuna = Tuna.x;
			map[xTuna, yTuna] = map[xShark, yShark];
			map[xShark, yShark] = null;
		}
		static void SharkDeath(Coordinates Shark)
		{
			map[Shark.x, Shark.y] = null;
		}

		static void PrintMap()
		{
			Console.Clear();
			Console.WriteLine();
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			for (int j = 0; j < map.GetLength(0); j++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
			for (int i = 0; i < map.GetLength(1); i++)
			{
				for( int j = 0;  j < map.GetLength(0); j++)
				{
					if (map[j, i] == null)
					{
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write(" ");
					}
					else
					if (map[j, i].type == Specimen.tuna)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write("O");
					}
					else
					if (map[j, i].type == Specimen.shark)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write("X");
					}
				}
				Console.WriteLine("|");
			}
			Console.WriteLine();
			for (int j = 0; j < map.GetLength(0); j++)
			{
				Console.Write("-");
			}
		}
		static bool SharkSonar(int sight, Coordinates x_y, out Coordinates SharkPosition)
		{
			int rangeHighY = sight - x_y.y;
			int rangeHighX = sight - x_y.x;
			int rangeLowX = sight + x_y.x;
			int rangeLowY = sight + x_y.y;
			bool entity = false;
			SharkPosition = new Coordinates();
			for (int i = rangeLowY; i < rangeHighY; i++)
				for (int j = rangeLowX; j < rangeHighX; j++)
					if (map[j, i] != null)
						if (map[j, i].type == Specimen.shark)
						{
							entity = true;
							SharkPosition.y = i;
							SharkPosition.x = j;
						}
			return entity;
		}
		static bool TunaSonar(int sight, Coordinates x_y, out Coordinates TunaPosition)
		{
			int rangeHighY = sight - x_y.y;
			int rangeHighX = sight - x_y.x;
			int rangeLowX = sight + x_y.x;
			int rangeLowY = sight + x_y.y;
			bool entity = false;
			TunaPosition = new Coordinates();
			for (int i = rangeLowY; i < rangeHighY; i++)
				for (int j = rangeLowX; j < rangeHighX; j++)
					if (map[j, i] != null)
						if (map[j, i].type == Specimen.tuna)
						{
							entity = true;
							TunaPosition.y = i;
							TunaPosition.x = j;
						}
			return entity;
		}
		static Cell[,] CreateMap(int xSize, int ySize, int numberOfSharks, int numberOfTunas)
		{
			Cell[,] planet = new Cell[xSize, ySize];
			Random random = new Random();
			for (int i = 0; i < numberOfSharks; i++)
			{
				int x = random.Next(xSize);
				int y = random.Next(ySize);
				if (planet[x, y] == null)
					planet[x, y] = CreateShark();
				else
					i--;
			}
			for (int i = 0; i < numberOfTunas; i++)
			{
				int x = random.Next(xSize);
				int y = random.Next(ySize);
				if (planet[x, y] == null)
					planet[x, y] = CreateTuna();
				else
					i--;
			}
			return planet;
		}
		static void Turn()
		// in un turno un tonno deve controllare se è obbligato a riprodursi, deve controllare nelle vicinanze i pericoli in caso non ce ne siano sta fermo e se possibile si riproduce 
		//
		{
			for (int i = 0; i < map.GetLength(0); i++)
				for (int j = 0; i < map.GetLength(1); j++)
				{
					if (map[i, j] != null)
					{
						Coordinates coordinate = new Coordinates();
						coordinate.y = j; coordinate.x = i;
						if (map[i, j].type == Specimen.tuna)
						{
							Random random = new Random();
							ref Tuna tuna = ref map[i, j].tuna;
							if (!tuna.reproductionActive)
							{
								
								// controlla in caso si possa riprodurre se ci sono degli squali
								Coordinates SharkPosition;
								if (!SharkSonar(TunaShark.tunaSight, coordinate, out SharkPosition))
								{
									
									
									if (tuna.reproductionAvailable)
									{
										// si riproduce
										tuna.reproductionActive = true;
										tuna.reproductionCycle = 0;
									}
									else
									{
										
									}
								}
								else
								{
									//scappa via nella direzione opposta
								}
							}
							else
							{
								if (tuna.reproductionWait == 2)
								{
									CreateTuna();
								}
								else
									tuna.reproductionWait++;
							}
						}
						else if (map[i, j].type == Specimen.shark)
						{
							Random random = new Random();
							ref Shark shark = ref map[i, j].shark;
							if (shark.deathCounter == TunaShark.sharkDeath)
							{
								Coordinates sharkPosition = new Coordinates { x = j, y = i};
								SharkDeath(sharkPosition);
							}
							else if (shark.digestion)
							{
								shark.digestionCounter--;
							}
							else
							{
								Coordinates TunaPosition;
								if(TunaSonar(TunaShark.sharkSight, coordinate, out TunaPosition))
								{
									// va nella direzione del tonno
									var difX = TunaPosition.x - i;
									var difY = TunaPosition.y - j;
									int direction = 0;
									if (Math.Abs(difY) < Math.Abs(difX))
									{
										if (difY > 0)
											direction = 4;
										else 
											direction = 2;
									}
									else
									{
										if (difX > 0)
											direction = 1;
										else
											direction = 3;
									}
									switch (direction)
									{
										case 1:// Ovest
											break;
										case 2:// Nord
											break;
										case 3:// Est
											break;
										case 4:// Sud
											break;
									}
								}
								else
								{
									int direction = random.Next(1,4);
									switch (direction) {
										case 1:// Ovest
											break;
										case 2:// Nord
											break;
										case 3:// Est
											break;
										case 4:// Sud
											break;
									}
									// va in una direzione a caso
								}
							}
						}
					}
				}
		}
		static void Main(string[] args)
		{
			int ySize = 50;
			int xSize = 100;
			TunaShark.numberOfSharks = (ySize * xSize * 5) / 100;
			TunaShark.numberOfTunas = (ySize * xSize * 10) / 100;
			TunaShark.tunaSight = 5;
			TunaShark.sharkDeath = 11;
			TunaShark.sharkSight = 3;
			TunaShark.tunaReproductionLowerRange = 6;
			TunaShark.tunaReproductionBiggerRange = 10;
			map = CreateMap(xSize, ySize, TunaShark.numberOfSharks, TunaShark.numberOfTunas);
			while(TunaShark.numberOfTunas != 0 || TunaShark.numberOfSharks != 0)
			{
				PrintMap();
			}
		}
	}
}