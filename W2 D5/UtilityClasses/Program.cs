﻿using System.Diagnostics;

public class Program 
{
	static void Main() 
	{
		try 
		{
			Console.WindowWidth = Console.LargestWindowWidth;
		}
		catch (PlatformNotSupportedException ex) 
		{
			Console.WriteLine(ex.Message);
		}
		Console.ForegroundColor = ConsoleColor.Green;
		Console.Write("test... 50%");
		Console.CursorLeft -= 3;
		Console.Write("90%");
		Console.ForegroundColor = ConsoleColor.White;
		
		Console.WriteLine();
		Console.WriteLine(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
	}
}