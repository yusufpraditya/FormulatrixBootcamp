using GarbageCollection;
public class Program 
{
	static void Main() 
	{
		// using(Car car = new("Honda")) 
		// {
		// 	// TODO..
		// }
		
		// https://learn.microsoft.com/en-us/dotnet/api/system.gc?view=net-7.0
		Garbage garbage = new();
		Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);
		Console.WriteLine("Generation: {0}", GC.GetGeneration(garbage));
		garbage.CreateGarbage(1000);
		
		GC.Collect(0);
		Console.WriteLine("Generation: {0}", GC.GetGeneration(garbage));
		
		GC.Collect(1);
		Console.WriteLine("Generation: {0}", GC.GetGeneration(garbage));
		
		
	}
}