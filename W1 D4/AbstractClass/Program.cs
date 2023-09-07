using Hewan;
public class Program 
{
	static void Main() 
	{
		// Animal animal = new(); // Can't create instance from abstract class.
		
		Cat cat = new();
		cat.Eat();
		
		Dog dog = new();
		dog.Eat();
	}
}