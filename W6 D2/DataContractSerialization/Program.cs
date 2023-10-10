using System.Runtime.Serialization;

public class Program 
{
	static void Main() 
	{
		string xmlPath1 = @"./data1.xml";
		// string xmlPath2 = @"./data2.xml";
		string xmlPath3 = @"./data3.xml";
		
		Car car1 = new() { Brand = "Tesla", Year = 3 };
		Car car2 = new() { Brand = "Honda", Year = 2 };
		
		car1.tireSize = 5;
		car2.tireSize = 4;
		
		List<Car> cars = new() { car1, car2 };
		
		// Serialize 1 instance
		var serializer1 = new DataContractSerializer(typeof(Car));
		using (FileStream fs = File.Create(xmlPath1)) 
		{
			serializer1.WriteObject(fs, car1);
		}
		
		// Deserialize 1 instance
		Car? serializedCar1;
		using (FileStream fs = File.OpenRead(xmlPath1)) 
		{
			serializedCar1 = (Car?) serializer1.ReadObject(fs);
			Console.WriteLine(serializedCar1?.tireSize);
			Console.WriteLine(serializedCar1?.Brand);
			Console.WriteLine(serializedCar1?.Year);
			Console.WriteLine(serializedCar1?.engineType); // ""
		}
		
		// Serialize Dictionary of Car
		Dictionary<int, Car> dictCars = new() { 
			{ 0, car1 },
			{ 1, car2 }	
		};
		
		var serializer3 = new DataContractSerializer(typeof(Dictionary<int, Car>));
		using (FileStream fs = File.Create(xmlPath3)) 
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
	private int _carPassword = 123456; // private modifiers can be serialized using DataContractSerializer
	public string engineType = "v1"; // there is no attribute, so it won't be serialized
}