using EqualityComparison;

public class Program 
{
	static void Main() 
	{
		float num1 = 123.1f;
		double num2 = 123.1;
		EqualityClass<float, double> eq = new EqualityClass<float, double>();
		Console.WriteLine(eq.isEqual(num1, num2));
		
		ChildClass child = new();
		ParentClass parent = child;
		Console.WriteLine(ReferenceEquals(child, parent)); // True
	}
}