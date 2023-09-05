using Constructor;

class Program 
{
	static void Main() 
	{
		Car mobil1 = new Car("v8", "honda", "bridgestone");
		Console.WriteLine(mobil1.EngineCheck());
		
		Car mobil2 = new Car("v8", "michelin", 300);
		Console.WriteLine(mobil2.TopSpeedCheck());
		
		
	}
}