using Hewan;
public class Program 
{
	static void Main() 
	{
		Cat cat = new();
		Animal animal = cat;
		
		animal.Move();
		cat.Move();
		
		Animal animal2 = new();
		Cat cat2 = new();
		
		animal2.Move();
		cat2.Move();
	}
}