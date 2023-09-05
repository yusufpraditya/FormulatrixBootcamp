namespace Mobil;

public class Car
{
	public Engine engine;
	public string? brand;
	public string? tire;	
	public int topSpeed;	
	
	public Car(Engine engine, string brand, string tire) 
	{
		this.engine = engine;
		this.brand = brand;
		this.tire = tire;
	}
	
	public Car(Engine engine, string tire, int topSpeed) 
	{
		this.engine = engine;
		this.tire = tire;
		this.topSpeed = topSpeed;
	}
	
	public Engine EngineCheck() 
	{
		return engine;
	}
	
	public int TopSpeedCheck() 
	{
		return topSpeed;
	}
}
