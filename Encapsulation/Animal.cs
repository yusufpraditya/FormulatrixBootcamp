namespace Hewan;

public class Animal
{
	protected string? _name;
	protected int _age;
	
	public Animal(string name, int age) 
	{
		_name = name;
		_age = age;
	}
	
	public string? GetName() 
	{
		return _name;
	}
	
	public int GetAge() 
	{
		return _age;
	}
}
