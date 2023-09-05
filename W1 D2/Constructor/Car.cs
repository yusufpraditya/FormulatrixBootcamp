namespace Constructor;

public class Car
{
	public string? engine;
	public string? brand;
	public string? tire;	
	public int topSpeed;	
	
	public Car(string engine, string brand, string tire) 
	{
		this.engine = engine;
		this.brand = brand;
		this.tire = tire;
	}
	
	public Car(string engine, string tire, int topSpeed) 
	{
		this.engine = engine;
		this.tire = tire;
		this.topSpeed = topSpeed;
	}
	
	public string? EngineCheck() 
	{
		return engine;
	}
	
	public int TopSpeedCheck() 
	{
		return topSpeed;
	}
}
