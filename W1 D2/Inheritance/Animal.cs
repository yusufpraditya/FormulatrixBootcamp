namespace Hewan;

public class Animal
{
	public string? name;
	public int age;
	
	public Animal(string name, int age)
	{
		Console.WriteLine($"Animal with name {name} and age {age} years old has been created.");
	}
	
	public Animal() 
	{
		// default constructor
	}
	
	public void Eat()
	{
		Console.WriteLine($"{name} has eaten.");
	}
}
