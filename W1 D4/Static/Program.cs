public class Program
{
	static void Main() 
	{
		Cat.MakeSound("Meow");
	}
}

// static class -> static variable, static method.
public static class Cat
{
	// public string name; // Error
	public static void MakeSound(string sound) 
	{
		Console.WriteLine(sound);
	}
}