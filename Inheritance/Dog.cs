namespace Hewan;

public class Dog : Animal
{
	public Dog(string name, int age) : base(name, age)
	{
		this.name = name;
		this.age = age;
		Console.WriteLine($"Dog with name {name} and age {age} has been created.");
	}
	
	public void Bark() {
		Console.WriteLine($"{name} is barking very loud.");
	}
}
