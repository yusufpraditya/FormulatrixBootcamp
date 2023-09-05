namespace Hewan;

public class Fish : Animal
{
	public Fish(string name, int age) : base(name, age)
	{
		this.name = name;
		this.age = age;
		Console.WriteLine($"Fish with name {name} and age {age} has been created.");
	}
	
	public void Swim() 
	{
		Console.WriteLine($"{name} is swimming happily.");
	}
}
