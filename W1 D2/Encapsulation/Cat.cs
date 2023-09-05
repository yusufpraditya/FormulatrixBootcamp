namespace Hewan;

public class Cat : Animal
{
	public Cat(string name, int age) : base(name, age)
	{
		Console.WriteLine($"Cat with name {name} and age {age} years old has been created.");
	}
}
