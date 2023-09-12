using System.Reflection;
using Difficulty;

public class Program 
{
	static void Main() 
	{
		Console.WriteLine("1. Easy");
		Console.WriteLine("2. Normal");
		Console.WriteLine("3. Hard");
		Console.WriteLine("4. Expert");
		Console.Write("Select the difficulty: ");
		bool success = int.TryParse(Console.ReadLine(), out int difficultySelector);
		if (success && difficultySelector >= 1 && difficultySelector <= 4) 
		{
			switch (difficultySelector) 
			{
				case (int) DifficultyEnum.Easy: 
					Console.WriteLine("Difficulty is set to Easy.");
					break;
				case (int) DifficultyEnum.Normal:
					Console.WriteLine("Difficulty is set to Normal.");
					break;
				case (int) DifficultyEnum.Hard:
					Console.WriteLine("Difficulty is set to Hard.");
					break;
				case (int) DifficultyEnum.Expert:
					Console.WriteLine("Difficulty is set to Expert.");
					break;
				default:
					Console.WriteLine("Difficulty is set to Easy.");
					break;
			}
		}
		else 
		{
			Console.WriteLine("Difficulty is unavailable.");
		}
	}
}