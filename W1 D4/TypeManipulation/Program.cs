public class Program 
{
	static void Main() 
	{
		// value type				
		int a = 3;
		int b = a;
		b = 2;
		Console.WriteLine("Value type result:");
		Console.WriteLine(a);
		Console.WriteLine(b);
		
		// reference type
		Number num1 = new Number(3);
		Number num2 = num1;
		num2.number = 2;
		Console.WriteLine("Reference type result:");
		Console.WriteLine(num1.number);
		Console.WriteLine(num2.number);
		
		// string is immutable
		// to make string mutable, use StringBuilder
		string text1 = "Hello";
		string text2 = text1;
		text2 = "World";
		Console.WriteLine(text1);
		Console.WriteLine(text2);
	}
}

public class Number 
{
	public int number;
	public Number(int x) 
	{
		number = x;
	}
}