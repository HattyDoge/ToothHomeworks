using System.Collections.Generic;
namespace DictionaryExercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> universalConstraint = new Dictionary<string, double>();
			
			// Add some elements to the dictionary. There are no
			// duplicate keys, but some of the values are duplicates.
			universalConstraint.Add("e", 2.718281828459045);
			universalConstraint.Add("pi", 3.41592653589793);
			universalConstraint.Add("dib", 6.67259 * Math.Pow(10, -11));
			universalConstraint.Add("avo", 6.02214086 * Math.Pow(10, 23));
			universalConstraint.Add("g", 9.82);
			universalConstraint.Add("c", 300000);

			Console.WriteLine("Fai un operazioni tra constanti o con numeri : valore operatore valore");
			while (true)
			{
				string[] operation = Console.ReadLine().Split(" ");
				double value1;
				double value2;
				if (!universalConstraint.TryGetValue(operation[0], out value1))
					if (!double.TryParse(operation[0], out value1))
					{
						Console.WriteLine("Primo valore non corretto\nReinserire i valori");
						continue;
					}
				if (!universalConstraint.TryGetValue(operation[0], out value2))
					if (!double.TryParse(operation[0], out value2))
					{
						Console.WriteLine("Secondo valore non corretto\nReinserire i valori");
						continue;
					}

			}
		}
	}
}