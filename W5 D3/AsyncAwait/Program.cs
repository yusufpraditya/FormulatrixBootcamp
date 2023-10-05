using System.Threading.Tasks;

public class Program 
{
	static void Main() 
	{
		Console.WriteLine("Hello");
		Task.Run(LoopAsync);
		while (true) 
		{
			string? input = Console.ReadLine();
			if (input == "x") break;
			else Console.WriteLine("Your input: " + input);
		}
	}
	
	static async Task LoopAsync() 
	{
		await Task.Run(async () => 
		{
			for (int i = 0; i < 100; i++) 
			{
				Console.WriteLine(i);
				await Task.Delay(1000);
			}
		});
	}
}