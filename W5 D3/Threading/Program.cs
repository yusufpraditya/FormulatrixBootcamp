
using System.Diagnostics;

public class Program 
{
	static void Main() 
	{
		Thread t1 = new Thread(ProcessA);
		Thread t2 = new Thread(ProcessB);
		
		// it's uncertain which thread is started first
		t1.Start();
		t2.Start();
		Console.WriteLine("Finished");
		
		// Blocking main thread
		Stopwatch sw = new();
		sw.Start();
		Thread.Sleep(1000); // 1000 miliseconds
		sw.Stop();
		Console.WriteLine("Main thread has been blocked in " + sw.Elapsed);
		
		// Lambda expression
		Thread t3 = new Thread(() => 
		{
			Console.WriteLine("My thread 3");
		});
		Thread t4 = new Thread(() => 
		{
			Console.WriteLine("My thread 4");
		});
		
		t3.Start();
		t4.Start();
		
		Thread t5 = new Thread(PrintX);
		Thread t6 = new Thread(PrintY);
		
		t5.Start();
		t6.Start();
	}

	static void ProcessA() 
	{
		Console.WriteLine("Hello world");
	}
	
	static void ProcessB() 
	{
		Console.WriteLine("Halo dunia");
	}
	
	static void PrintX() 
	{
		for (int i = 0; i < 10; i++) 
		{
			Console.Write("x");
		}
	}
	
	static void PrintY() 
	{
		for (int i = 0; i < 10; i++) 
		{
			Console.Write("y");
		}
	}
}