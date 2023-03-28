using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace DictionaryExercise
{
	internal class Program
	{
		static string[] Input(out double value1, out double value2, Dictionary<string, double> universalConstraint)
		{
			string[] operation = { "2", "3", "4" };
			while (true)
			{
				operation = Console.ReadLine().Split(" ");
				if (!universalConstraint.TryGetValue(operation[0], out value1))
					if (!double.TryParse(operation[0], out value1))
					{
						Console.WriteLine("Primo valore non corretto\nReinserire i valori");
						continue;
					}
				if (!universalConstraint.TryGetValue(operation[2], out value2))
					if (!double.TryParse(operation[2], out value2))
					{
						Console.WriteLine("Secondo valore non corretto\nReinserire i valori");
						continue;
					}
				break;
			}

			return operation;
		}
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
			string[] operation;
			double value1;
			double value2;
			double result = 0;
			while (true)
			{
				operation = Input(out value1, out value2, universalConstraint);
				bool switchHappened = false;
				switch (operation[1])
				{
					case "+":
						switchHappened = true;
						result = value1 + value2;
						break;

					case "-":
						switchHappened = true;
						result = value1 - value2;
						break;

					case "*":
						switchHappened = true;
						result = value1 * value2;
						break;

					case "/":
						switchHappened = true;
						result = value1 / value2;
						break;
				}
				if (!switchHappened)
					continue;
				break;
			}
			Console.WriteLine($"Il risultato dell'operazione tra {operation[0]} {operation[1]} {operation[2]} è {value1} {operation[1]} {value2} = {result} ");
		}
	}
}