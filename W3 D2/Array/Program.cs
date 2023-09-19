public class Program 
{
	static void Main() 
	{
		// two ways to create Array
		int[] numbers1 = {1, 2, 3, 4, 5};
		int[] numbers2 = new int[5];
		numbers2[0] = 1;
		numbers2[1] = 2;
		numbers2[2] = 3;
		numbers2[3] = 4;
		numbers2[4] = 5;

		// resize array
		Array.Resize(ref numbers1, 10);
		Console.WriteLine(numbers1.Length);
		
		// reverse array
		Array.Reverse(numbers2); // 5 4 3 2 1
		foreach (var number in numbers2) 
		{
			Console.WriteLine(number); 
		}

		// sort array -> ascending
		Array.Sort(numbers2);
		foreach (var number in numbers2) 
		{
			Console.WriteLine(number);
		}
	}
}