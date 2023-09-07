using System.Text;

public class Program 
{
	static void Main() 
	{
		StringBuilder sb = new();
		sb.Append("Hello world ");
		Console.WriteLine(sb);
		Console.WriteLine(sb.Length);
		
		for(int i = 0; i < 10; i++) 
		{
			sb.Append(i.ToString());
		}
		Console.WriteLine(sb);
		
		// Replace "Hello" to "Halo" and "world" to "dunia"
		StringBuilder sb2 = new();
		sb2.Append("Hello world");
		sb2.Replace("Hello", "Halo");
		sb2.Replace("world", "dunia");
		Console.WriteLine(sb2);
		
		// Convert StringBuilder to string
		Console.WriteLine(sb2.GetType());
		string text = sb2.ToString();
		Console.WriteLine(text.GetType());
		
		// Clearing StringBuilder with Clear()
		sb2.Clear();
		Console.WriteLine(sb2);
		Console.WriteLine(sb2.Length);
		
		// Clearing StringBuilder by setting Length property to 0
		sb.Length = 0;
		Console.WriteLine(sb);
		Console.WriteLine(sb.Length);
		
		// Compare two StringBuilder
		Console.WriteLine();
		StringBuilder sb4 = new StringBuilder("Hello");
		StringBuilder sb5 = new StringBuilder("Hello", 64);
		Console.WriteLine(sb4.Capacity);
		Console.WriteLine(sb5.Capacity);
		Console.WriteLine(sb4.Equals(sb5));
	}
}