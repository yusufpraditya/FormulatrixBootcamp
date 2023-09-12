using GenericCollection;

public class Program 
{
	static void Main() 
	{
		List<int> list = new List<int>
		{
			1,
			2,
			3,
			4
		};
		
		foreach (var l in list) 
		{
			Console.WriteLine(l);
		}
		
		List<Car> carList = new List<Car>
		{
			new Car("Honda", 300),
			new Car("Toyota", 200),
			new Car("Ferrari", 500)
		};
		carList[0].TopSpeed = 200;
		carList[1].BrandName = "Tayo";
		
		foreach (var c in carList) 
		{
			Console.WriteLine($"{c.BrandName} has top speed of {c.TopSpeed} kmh.");
		}
		
		Dictionary<int, Car> dict = new Dictionary<int, Car>
		{
			{ (int)BrandEnum.Honda, new Car(BrandEnum.Honda.ToString(), 300) },
			{ (int)BrandEnum.Toyota, new Car(BrandEnum.Toyota.ToString(), 200) },
			{ (int)BrandEnum.Ferrari, new Car(BrandEnum.Ferrari.ToString(), 500) },
			// { (int)BrandEnum.Ferrari, new Car(BrandEnum.Ferrari.ToString(), 500) } // Exception, An item with the same key has already been added. Key: 3
		};
		
		foreach (var d in dict) 
		{
			Console.WriteLine($"{d.Value.BrandName} has top speed of {d.Value.TopSpeed} kmh.");
		}
	}
}