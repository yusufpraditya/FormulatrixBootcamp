using GenericConstraints;

public static class Program 
{
	static void Main() 
	{
		Car car = new();
		car.CarName = "Toyota";
		car.GetInfo(car.CarName);
		car.GetInfo("Honda", 200);
		// car.GetInfo(200, "Honda"); // <- error, first param should be class & second param should be struct
	}
}