using Var;

public class Program 
{
	static void Main() 
	{
		var variable1 = 123;
		Console.WriteLine(variable1.GetType());

		var variable2 = 123.1f;
		Console.WriteLine(variable2.GetType());

		var variable3 = 123.1;
		Console.WriteLine(variable3.GetType());

		var variable4 = 123.1M;
		Console.WriteLine(variable4.GetType());

		var variable5 = "123";
		Console.WriteLine(variable5.GetType());
		
		var variable6 = new Class1();
		Console.WriteLine(variable6.GetType());
	}
}

