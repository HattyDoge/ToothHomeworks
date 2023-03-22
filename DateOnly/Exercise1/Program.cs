using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise;

public static class Program
{
	public static void DateDifference(DateOnly date1, DateOnly date2)
	{
		int daysDifference;
		if (date1 > date2)
		{
			daysDifference = date1.DayNumber - date2.DayNumber;
		}
		else
		{
			daysDifference = date2.DayNumber - date1.DayNumber;
		}
		Console.WriteLine(daysDifference + " giorni");
	}
	public static void InternExtern(TimeOnly tempo)
	{
		TimeOnly internTimeLeft = new TimeOnly(16, 0);
		TimeOnly internTimeRight = new TimeOnly(22, 0);
		if (tempo < internTimeRight && tempo > internTimeLeft)
		{
			Console.WriteLine("interno");
		}
		else
			Console.WriteLine("esterno");
	}
	public static void SmallestGap(DateTime[] dates)
	{
		int smallI = 0;
		int smallJ = 0;
		TimeSpan diff = dates[0].Subtract(dates[1]);
		TimeSpan smallGape = diff;
		for (int i = 0; i < dates.Length - 1; i++)
			for (int j = i + 1; j < dates.Length; j++)
			{
				diff = dates[i].Subtract(dates[j]);
				if (Math.Abs(diff.TotalSeconds) < Math.Abs(smallGape.TotalSeconds))
				{
					smallGape = diff;
					smallI = i;
					smallJ = j;
				}
			}
		Console.WriteLine($"Le due date sono {dates[smallI]} e {dates[smallJ]}");
	}

	public static void Main()
	{
		DateOnly date1 = DateOnly.Parse(Console.ReadLine());
		DateOnly date2 = DateOnly.Parse(Console.ReadLine());
		DateDifference(date1, date2);
		Console.WriteLine("Tempo");
		TimeOnly tempo = TimeOnly.Parse(Console.ReadLine());
		InternExtern(tempo);
		DateTime[] dates = {
			new DateTime(2014, 6, 14, 6, 32, 0),
			new DateTime(2014, 7, 10, 23, 49, 0),
			new DateTime(2015, 1, 10, 1, 16, 0),
			new DateTime(2014, 12, 20, 21, 45, 0),
			new DateTime(2014, 6, 2, 15, 14, 0)
		};
		SmallestGap(dates);
	}
}