using Mobil;
class Program 
{
	static void Main() 
	{
		Engine engine = new Engine("v8", 495, 470);
		
		Car honda = new Car(engine, "bridgestone", 300);

		Console.WriteLine(honda.EngineCheck().engineType);
		Console.WriteLine(honda.EngineCheck().horsePower);
		Console.WriteLine(honda.EngineCheck().torque);
		Console.WriteLine(honda.TopSpeedCheck());
	}
}