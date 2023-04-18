namespace TextFiles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string fileRep = @"..\..\..\TextFile.txt";
			int[] vector = new int[100];
			try
			{
				using (StreamReader sr = new StreamReader(fileRep))
				{
					while (!sr.EndOfStream)
					{
						
						try
						{
							string[] line = sr.ReadLine().Split(" ");
							int[] numbers = { int.Parse(line[0]), int.Parse(line[1]) };
							if (numbers[0] > 99 || numbers[0] < 0)
								numbers[0] = 0;
							vector[numbers[0]] = numbers[1];
						}
						catch
						{
							Console.WriteLine("The vector can't be acquired");
						}
					}
				}

			} 
			catch (FileNotFoundException) 
			{
				Console.WriteLine("File in repository missing");
			}
			for (int i = 0; i < vector.Length; i++)
			{
				Console.WriteLine($"{i} {vector[i]}");
			}
		}
	}
}