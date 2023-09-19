using System.Collections;

public class Program 
{
	static void Main() 
	{
		// ArrayList is not safety
		ArrayList list = new ArrayList() {
			1, "2", true, 3.4, 123.1f, 111M, new int[] {1, 2, 3}
		};

		// must unbox to access element of ArrayList
		int intValue = (int) list[0];
		Console.WriteLine(intValue);
	}
}