using System.Xml.Serialization;

public class Program 
{
	static void Main() 
	{
		string xmlPath1 = @"./data1.xml";
		string xmlPath2 = @"./data2.xml";
		// string xmlPath3 = @"./data3.xml";
		
		Car car1 = new() { Brand = "Tesla", Year = 3 };
		Car car2 = new() { Brand = "Honda", Year = 2 };
		
		car1.tireSize = 5;
		car2.tireSize = 4;
		
		List<Car> cars = new() { car1, car2 };
		
		// Serialize 1 instance
		XmlSerializer serializer1 = new(typeof(Car));
		using (FileStream fs = new(xmlPath1, FileMode.Create)) 
		{
			serializer1.Serialize(fs, car1);
		}
		
		// Deserialize 1 instance
		Console.WriteLine("Deserialize 1 instance");
		Car? deserializedCar1;
		using(StreamReader sr = new(xmlPath1)) 
		{
			deserializedCar1 = (Car?) serializer1.Deserialize(sr);
			Console.WriteLine(deserializedCar1?.tireSize);
			Console.WriteLine(deserializedCar1?.Year);
			Console.WriteLine(deserializedCar1?.Brand);
			Console.WriteLine(typeof(Car));
		}
		
		// Serialize more than 1 instance
		XmlSerializer serializer2 = new(typeof(List<Car>));
		using (FileStream fs = new(xmlPath2, FileMode.Create)) 
		{
			serializer2.Serialize(fs, cars);
		}
		
		// Deserialize more than 1 instance
		Console.WriteLine("\nDeserialize more than 1 instance");
		List<Car>? deserializedCar2;
		using(StreamReader sr = new(xmlPath2)) 
		{
			deserializedCar2 = (List<Car>?) serializer2.Deserialize(sr);
			if (deserializedCar2 != null) 
			{
				foreach (var c in deserializedCar2) 
				{
					Console.WriteLine(c?.tireSize);
					Console.WriteLine(c?.Year);
					Console.WriteLine(c?.Brand);
				}
			}
		}
		
		// Serialize Dictionary of Car -> exception
		// Dictionary<int, Car> dictCars = new() { 
		// 	{ 0, car1 },
		// 	{ 1, car2 }	
		// };
		
		// XmlSerializer serializer3 = new(typeof(Dictionary<int, Car>));
		// using (FileStream fs = new(xmlPath3, FileMode.Create)) 
		// {
		// 	serializer3.Serialize(fs, dictCars);
		// }
	}
}

public class Car 
{
	// XmlSerializer can serialize public fields and public properties
	public int tireSize;
	public string? Brand { get; set; }
	public int Year { get; set; }
}