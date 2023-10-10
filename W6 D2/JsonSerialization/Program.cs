using System.Text.Json;

public class Program 
{
	static void Main() 
	{
		string jsonPath1 = @"./data1.json";
		string jsonPath2 = @"./data2.json";
		string jsonPath3 = @"./data3.json";
		
		Car car1 = new() { Brand = "Tesla", Year = 3 };
		Car car2 = new() { Brand = "Honda", Year = 2 };
		
		car1.tireSize = 5;
		car2.tireSize = 4;
		
		List<Car> cars = new() { car1, car2 };
		
		// Serialize 1 instance
		string serializer1 = JsonSerializer.Serialize(car1);
		using  (StreamWriter sw = new(jsonPath1)) 
		{
			sw.Write(serializer1);
		}
		
		// Deserialize 1 instance
		Console.WriteLine("Deserialize 1 instance");
		Car? deserializedCar1;
		using (StreamReader sr = new(jsonPath1)) 
		{
			string deserializedJson = sr.ReadToEnd();
			deserializedCar1 = JsonSerializer.Deserialize<Car>(deserializedJson);
			Console.WriteLine(deserializedCar1?.tireSize); // 0
			Console.WriteLine(deserializedCar1?.Brand);
			Console.WriteLine(deserializedCar1?.Year);
		}
		
		// Serialize more than 1 instance
		string serializer2 = JsonSerializer.Serialize(cars);
		using  (StreamWriter sw = new(jsonPath2)) 
		{
			sw.Write(serializer2);
		}
		
		// Deserialize more than 1 instance
		Console.WriteLine("\nDeserialize more than 1 instance");
		List<Car>? deserializedCar2;
		using (StreamReader sr = new(jsonPath2)) 
		{
			string deserializedJson = sr.ReadToEnd();
			deserializedCar2 = JsonSerializer.Deserialize<List<Car>>(deserializedJson);
			if (deserializedCar2 != null) 
			{
				foreach (var c in deserializedCar2) 
				{
					Console.WriteLine(c.tireSize); // 0
					Console.WriteLine(c.Brand);
					Console.WriteLine(c.Year);
				}
			}	
		}
		
		// Serialize Dictionary of Car
		Dictionary<int, Car> dictCars = new() 
		{
			{ 0, car1 },
			{ 1, car2}
		};
		
		string serializer3 = JsonSerializer.Serialize(dictCars);
		using  (StreamWriter sw = new(jsonPath3)) 
		{
			sw.Write(serializer3);
		}
	}
}

public class Car 
{
	// JsonSerializer can only serialize public properties
	public int tireSize; // this field won't be serialized
	public string? Brand { get; set; }
	public int Year { get; set; }
}