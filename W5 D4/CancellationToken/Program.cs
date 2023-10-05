public class Program 
{
	static void Main()
	{
		CancellationTokenSource cts = new();
		CancellationToken token = cts.Token;
		
		Task t1 = Task.Run(() => PrintLoop(token));
		
		while (!t1.IsCanceled)
		{
			if (Console.ReadKey().KeyChar == 'x') 
			{
				cts.Cancel();
				break;
			}
		}
	}
	
	static async void PrintLoop(CancellationToken token) 
	{
		int counter = 0;
		while (!token.IsCancellationRequested) 
		{
			Console.WriteLine(counter++);
			await Task.Delay(1000);
		}
	}
}