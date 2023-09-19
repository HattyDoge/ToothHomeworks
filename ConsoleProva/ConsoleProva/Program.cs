using System.Collections.Generic;

namespace ProvaConsoleCS
{
	internal class Program
	{
		static bool Check(string ex)
		{
			List<char> stack = new List<char>();
			foreach (char s in ex)
			{
				if (s == '(')
					stack.Add(')');
				if( s == '{')
					stack.Add('}');
				if( s == '[')
					stack.Add(']');

				if (s == ')' || s == '}' || s == ']')
				{
					if (s == stack[stack.Count - 1])
					{
						stack.RemoveAt(stack.Count - 1);
					}
					else
						return false;
				}
			}
			if (stack.Count > 0)
				return false;
			return true;

		}
		static void Main(string[] args)
		{
			//  controllo bilanciamento delle parentesi 
			string exp = "{( 5 + 5 )[ 23 * {32 + 3} - 34 (23 + 3) ]}";
			if (Check(exp))
				Console.WriteLine("Giusto");
			else
				Console.WriteLine("Sbagliato");

			exp = "{( 5 + 5 ){[ 23 * {32 + 3} - 34 (23 + 3) ]}";
			if (Check(exp))
				Console.WriteLine("Giusto");
			else
				Console.WriteLine("Sbagliato");

			exp = "{( 5 + 5 ){[ 23 * {32 + 3} - 34 (23 + 3)] ]}}";
			if (Check(exp))
				Console.WriteLine("Giusto");
			else
				Console.WriteLine("Sbagliato");
		}
	}
}