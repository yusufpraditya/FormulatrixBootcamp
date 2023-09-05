namespace Hewan;

public class Cat : Animal
{
	public Cat(string name, int age) : base(name, age)
	{
		this.name = name;
		this.age = age;
		Console.WriteLine($"Cat with name {name} and age {age} has been created.");
	}
	
	public void Meow() 
	{
		Console.WriteLine($"{name} is meowing calmly.");
	}
}
