namespace GenericConstraints;
public class Car : IEngine
{
	private string? _carName;
	public string? CarName 
	{
		get => _carName;
		set => _carName = value;
	}

    // Generic method
    public void GetInfo<T>(T t) where T : class
	{
		Console.WriteLine("Info 1: " + t);
	}
	// Generic method
	public void GetInfo<T1, T2>(T1 t1, T2 t2) 
	where T1 : class
	where T2 : struct 
	{
		Console.WriteLine("Info 1: " + t1);
		Console.WriteLine("Info 2: " + t2);
	}
	public void RunEngine() 
	{
		Console.WriteLine("Engine is running");
	}
}
