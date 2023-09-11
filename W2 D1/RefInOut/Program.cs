public class Program 
{
	static void Main() 
	{
		// ref
		int x = 10;
		Console.WriteLine("x: " + x);
		RefAdd(ref x);
		Console.WriteLine("x: " + x);
		
		// in -> read only
		int y = 10;
		InAdd(in y);
		
		// out -> out method must be assigned
		OutAdd(out int z); // can use unassigned variable. in this example, variable 'z' is unassigned.
		
		// another "out" example
		string StringNumber = "123";
		bool status = int.TryParse(StringNumber, out int result);
		Console.WriteLine($"Parse status: {status}");
		Console.WriteLine($"Parse result: {result} ({result.GetType()})");
	}
	
	static void RefAdd(ref int x) 
	{
		x += 1;
		Console.WriteLine("x: " + x);
	}
	
	static void InAdd(in int y) 
	{
		// y += 1; // Cannot assign to variable 'y' or use it as the right hand side of a ref assignment because it is a readonly variable
		int y2 = y + 10;
		Console.WriteLine("y2: " + y2);
	}
	
	static void OutAdd(out int z) 
	{
		// Console.WriteLine(z); // Use of unassigned out parameter 'z'
		z = 30;
		Console.WriteLine("z: " + z);
	}
}