﻿using System.Diagnostics;

namespace advent_of_code_2024;

// dotnet run -c Release -- -day=5

public class Program
{
	public static void Main(string[] args)
	{
		int day = ValidateArgs(args);

		Console.WriteLine($"""
			===== Advent of Code 2024 =====

			Day {day:D2}:

			""");

		long startTime = Stopwatch.GetTimestamp();

		switch (day)
		{
			case 1:
				Day01.SolvePart1();
				Day01.SolvePart2();
				break;
			case 2:
				Day02.SolvePart1();
				Day02.SolvePart2();
				break;
			case 3:
				Day03.SolvePart1();
				Day03.SolvePart2();
				break;
			case 4:
				Day04.SolvePart1();
				Day04.SolvePart2();
				break;
			case 5:
				Day05.SolvePart1();
				Day05.SolvePart2();
				break;
			default:
				throw new Exception("Invalid day. Day not found");
		}

		TimeSpan elapsed = Stopwatch.GetElapsedTime(startTime);
		int elapsedMs = (int)Math.Floor(elapsed.TotalMilliseconds);
		Console.WriteLine($"The program finished in {elapsedMs} ms");
	}

	private static int ValidateArgs(string[] args)
	{
		if (args.Length != 1 || !args.Any(a => a.Contains("-day=")))
		{
			throw new Exception("Missing argument 'day'.\nExample: -day=4");
		}

		string dayArg = args[0].Replace("-day=", string.Empty);
		if (!int.TryParse(dayArg, out int day))
		{
			throw new Exception("Invalid value in argument 'day'");
		}

		if (day is < 1 or > 25)
		{
			throw new Exception("Invalid value in argument 'day'");
		}

		return day;
	}
}
