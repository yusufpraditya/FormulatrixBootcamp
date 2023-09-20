public class Program 
{
	static void Main() 
	{
		Dictionary<int, string> dict = new Dictionary<int, string>(){{3, "foo"}, {5, "bar"}};
		dict.Add(7, "fizz");
		dict.Add(9, "buzz");

		PrintDictionary(dict);
		
		dict.Remove(3);
		PrintDictionary(dict);
		
		bool status = dict.TryGetValue(3, out string? result);
		Console.WriteLine($"{status} - {result}");
	}
	
	static void PrintDictionary(Dictionary<int, string> dict) 
	{
		Console.WriteLine();
		foreach (var kvp in dict) 
		{
			Console.WriteLine($"{kvp.Key} - {kvp.Value}");
		}
	}
}