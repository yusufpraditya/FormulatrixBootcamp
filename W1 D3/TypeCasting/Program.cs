public class Program 
{
	static void Main() 
	{
		// Implicit casting or up casting, small type size -> big type size
		int num1 = 100; // 32 bit / 4 bytes
		double num2 = num1; // 64 bit / 8 bytes
		Console.WriteLine("Implicit casting (up casting)");
		Console.WriteLine($"Size of int: {sizeof(int)} bytes");
		Console.WriteLine($"Size of double: {sizeof(double)} bytes");
		Console.WriteLine(num2);
		
		// Explicit casting or down casting, big type size -> small type size
		Console.WriteLine("Explicit casting (down casting)");
		double num3 = 100.1;
		int num4 = (int) num3;
		Console.WriteLine(num4);		
	
		decimal num5 = 100.1M;
		int num6 = (int) num5;
		Console.WriteLine(num6);
		
		// Down casting on Instance
		ParentClass parent = new();
		ChildClass child = (ChildClass) parent;
		child.SomeMethod();
		child.SomeNewMethod();
		
		// Child -> Parent -> Child
		// todo: InvalidCastException
		ChildClass origin = new();
		ParentClass newParent = origin;
		ChildClass newChild = (ChildClass) newParent;
	}
}

public class ParentClass 
{
	public void SomeMethod() 
	{
		Console.WriteLine("Do something");
	}
}

public class ChildClass : ParentClass 
{
	public void SomeNewMethod() 
	{
		Console.WriteLine("Do another thing");
	}
}

