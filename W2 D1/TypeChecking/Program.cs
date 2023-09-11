using TypeChecking;
public class Program 
{
	static void Main() 
	{
		object class1 = new Class1();
		object class2 = new Class2();
		object IntNumber = 123;
		object Text = "Hello world";
		
		if (IntNumber is int) 
		{
			Console.WriteLine("IntNumber is int");
		}
		
		if (IntNumber is ValueType) 
		{
			Console.WriteLine("IntNumber is value type");
		}
		
		if (Text is ValueType) 
		{
			Console.WriteLine("Text is value type");
		} else 
		{
			Console.WriteLine("Text is reference type");
		}
		
		if (class1 is Class1) 
		{
			Console.WriteLine("class1 is Class1");
		}
		
		if (class2.GetType().IsClass) 
		{
			Console.WriteLine("class2 is Class");
		}
	}
}