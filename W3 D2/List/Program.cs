using List;

public class Program 
{
	static void Main() 
	{
		List<int> listOfNumbers = new List<int>() {2, 4, 1, 9, 3, 5};
		PrintList(listOfNumbers, nameof(listOfNumbers));
		
		// Ascending
		listOfNumbers.Sort();
		PrintList(listOfNumbers, nameof(listOfNumbers));
		
		listOfNumbers.Reverse();
		PrintList(listOfNumbers, nameof(listOfNumbers));
		
		List<Car> cars = new List<Car>() {new Car("honda", 200), new Car("ferrari", 400), new Car("toyota", 150)};
		
		Console.WriteLine();
		Console.WriteLine("Before sort");
		foreach (var car in cars) 
		{
			Console.WriteLine($"{car.BrandName} - {car.TopSpeed} kmh");
		}
		
		Console.WriteLine();
		Console.WriteLine("After sort");
		cars.Sort((car1, car2) => car1.TopSpeed.CompareTo(car2.TopSpeed)); // Sort cars based on TopSpeed
		foreach (var car in cars) 
		{
			Console.WriteLine($"{car.BrandName} - {car.TopSpeed} kmh");
		}
	}
	
	static void PrintList(List<int> list, string varName) 
	{
		Console.Write(varName + ": ");
		foreach (var item in list) 
		{
			Console.Write($"{item} ");
		}
		Console.WriteLine();
	}
}