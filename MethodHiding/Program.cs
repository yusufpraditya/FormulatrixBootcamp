using Hewan;

public class Program 
{
	static void Main() 
	{
		Cat cat = new();
		Animal animal = cat;
		
		animal.Move();
		cat.Move();
	}	
}
