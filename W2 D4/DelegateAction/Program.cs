public class Program 
{
	static void Main() 
	{
		// Action generic only accepts input and has no return type (void)
		Action<int> action1 = PrintInt;	
		action1 += PrintSquaredInt; // Subscribe or register more method
		action1(10);
	}
	
	static void PrintInt(int x) 
	{
		Console.WriteLine(x.ToString());
	}
	
	static void PrintSquaredInt(int x) 
	{
		Console.WriteLine((x*x).ToString());
	}
}