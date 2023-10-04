public class Program 
{
	static void Main() 
	{
		// Task runs on background thread
		Task task1 = new Task(Print);
		task1.Start();
		task1.Wait();
		
		Task.Run(() => 
		{
			Console.WriteLine("Halo dunia");
		});
		
		Task task2 = Task.Run(() => 
		{
			Console.WriteLine("Do something");
		});
		
		Task task3 = Task.Run(() => 
		{
			Console.WriteLine("Do another thing");
		});
		
		Task.WaitAll(task2, task3);
		
		Console.WriteLine("Task delay started");
		Task task4 = Task.Run(async () => 
		{
			Console.WriteLine("Process A");
			await Task.Delay(1000);
			Console.WriteLine("Process finished");
		});
		task4.Wait();
		Console.WriteLine("Task delay finished");
		
	}
	
	static void Print() { 
		Console.WriteLine("Hello world");
	}
}