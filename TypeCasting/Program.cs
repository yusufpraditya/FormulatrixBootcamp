public class Program 
{
	static void Main() 
	{
		// Implicit casting or up casting, small type size -> big type size
		int num1 = 100; // 32 bit
		float num2 = num1; // 64 bit
		Console.WriteLine(num2);
		
		// Explicit casting or down casting, big type size -> small type size
		float num3 = 100.1f;
		int num4 = (int) num3;
		Console.WriteLine(num4);
		
		double num5 = 100.1;
		int num6 = (int) num5;
		Console.WriteLine(num6);
		
		decimal num7 = 100.1M;
		int num8 = (int) num7;
		Console.WriteLine(num8);
		
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

