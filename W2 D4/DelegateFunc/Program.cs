public class Program 
{
	static void Main() 
	{
		// If only 1 generic type is passed, it is the return type of the registered method
		Func<string> func1 = Print;
		Console.WriteLine(func1());
		
		// If more than 1 generic type is passed, the last one is the return type, while the rest is the input
		Func<int, string> func2 = IntToString;
		Console.WriteLine(func2(123));
		
		// Up to 16 inputs
		Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, string> func3 = Add16IntsToString;
		Console.WriteLine(func3(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1));
	}
	
	static string Print() 
	{
		return "Hello world";
	}
	
	static string IntToString(int input) 
	{
		return input.ToString();
	}
	
	static string Add16IntsToString(int inp1, int inp2, int inp3, int inp4, int inp5, int inp6, int inp7, int inp8, int inp9, int inp10, int inp11, int inp12, int inp13, int inp14, int inp15, int inp16) 
	{
		return (inp1 + inp2 + inp3 + inp4 + inp5 + inp6 + inp7 + inp8 + inp9 + inp10 + inp11 + inp12 + inp13 + inp14 + inp15 + inp16).ToString();
	}
}