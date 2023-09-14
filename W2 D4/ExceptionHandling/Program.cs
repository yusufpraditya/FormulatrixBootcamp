public class Program 
{
	static void Main() 
	{
		// DivideByZeroException
		// int a = 1;
		// int b = 0;
		// int c = a / b;
		// Console.WriteLine(c.ToString());
		
		// Exception Handling
		int d = 1;
		int e = 0;
		try
		{
			// Put statement as minimum as possible in try block
			int f = d / e;
		}
		catch (DivideByZeroException ex) 
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.WriteLine("This statement is always executed.");
		}
		
		// Handling FormatException
		string numString = "123a";
		try 
		{
			int num = int.Parse(numString);
		}
		catch (FormatException ex) 
		{
			Console.WriteLine(ex.Message);
		}
		
		// Better to handle using TryParse
		bool success = int.TryParse(numString, out int result);
		if (success) Console.WriteLine(result);
		else Console.WriteLine("Can't parse.");
		
	}
}