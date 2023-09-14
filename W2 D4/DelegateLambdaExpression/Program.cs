public class Program 
{
	static void Main() 
	{	
		// Lambda expression: (input parameters) => (statement)
		Func<int, int> func1 = (int x) => (x * x);
		Console.WriteLine(func1(10));
		
		// Lambda expression: (input parameters) => (block statements)
		Func<int, int, string> func2 = (int a, int b) => 
		{
			if (a % b == 0) 
			{
				return "foobar";
			}
			return "fizzbuzz";
		};
		Console.WriteLine(func2(15, 5));
		Console.WriteLine(func2(1, 2));
		
		// Lambda expression in Action
		Action<int, int> action1 = (int a, int b) => Console.WriteLine((a + b).ToString());
		action1(10, 10);
	}
}