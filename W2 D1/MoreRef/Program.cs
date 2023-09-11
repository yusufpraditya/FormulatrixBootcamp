using MoreRef;

public class Program 
{
	static void Main() 
	{
		Car car1 = new Car("toyota");
		Console.WriteLine($"Before calling the method: {car1.name}");
		
		// Pass a reference type by reference
		ChangeName(ref car1, "honda");
		Console.WriteLine($"After calling the method: {car1.name}");
	}
	
	static void ChangeName(ref Car car, string newName) 
	{
		car.name = newName;
		car = new Car("supra");
		Console.WriteLine($"Inside ChangeName: {car.name}");
	}
}