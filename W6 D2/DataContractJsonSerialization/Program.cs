using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
public class Program 
{
	static void Main() 
	{
		string jsonPath1 = @"./data1.json";
		// string jsonPath2 = @"./data2.json";
		string jsonPath3 = @"./data3.json";
		
		Car car1 = new() { Brand = "Tesla", Year = 3 };
		Car car2 = new() { Brand = "Honda", Year = 2 };
		
		car1.tireSize = 5;
		car2.tireSize = 4;
		
		List<Car> cars = new() { car1, car2 };
		
		// Serialize 1 instance
		var serializer1 = new DataContractJsonSerializer(typeof(Car));
		using (FileStream fs = File.Create(jsonPath1)) 
		{
			serializer1.WriteObject(fs, car1);
		}
		
		// Serialize Dictionary of Car
		Dictionary<int, Car> dictCars = new() 
		{
			{ 0, car1 },
			{ 1, car2 }
		};
		var serializer3 = new DataContractJsonSerializer(typeof(Dictionary<int, Car>));
		using (FileStream fs = File.Create(jsonPath3)) 
		{
			serializer3.WriteObject(fs, dictCars);
		}
	}
}

[DataContract]
public class Car 
{
	[DataMember]
	public int tireSize;
	[DataMember]
	public string? Brand { get; set; }
	[DataMember]
	public int Year { get; set; }
	[DataMember]
	private int _carPassword = 123456; // private modifiers can be serialized using DataContractJsonSerializer
	public string engineType = "v1"; // there is no attribute, so it won't be serialized
}