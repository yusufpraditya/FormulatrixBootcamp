using GenericClass;

public class Program 
{
	static void Main() 
	{
		Car<Enum, int> car1 = new Car<Enum, int>(EngineEnum.Electric, 300);
		Console.WriteLine(car1.GetEngine());
		car1.SetEngine(EngineEnum.Jet);
		Console.WriteLine(car1.GetEngine());
		
		Console.WriteLine(car1.GetTopSpeed());
		car1.SetTopSpeed(900);
		Console.WriteLine(car1.GetTopSpeed());
	}
}
