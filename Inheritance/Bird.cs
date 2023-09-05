namespace Hewan;

public class Bird : Animal
{
	public Bird(string name, int age) : base(name, age)
	{
		this.name = name;
		this.age = age;
		Console.WriteLine($"Bird with name {name} and age {age} has been created.");
	}
	
	public void Fly() 
	{
		Console.WriteLine($"{name} is flying happily.");
	}
}
