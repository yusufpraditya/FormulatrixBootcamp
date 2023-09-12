using System.Collections;

public class Program 
{
	static void Main() 
	{
		// ArrayList accepts all objects, it is not safety collection.
		ArrayList arrList = new ArrayList();
		arrList.Add(new Class1());
		arrList.Add(3);
		arrList.Add("abcdef");
		((Class1)arrList[0]).Method1();
		// ((Class1)arrList[1]).Method1(); // Unable to cast object of type 'System.Int32' to type 'Class1'.
	}
}

public class Class1 
{
	public void Method1() 
	{
		Console.WriteLine("Hi");
	}
}