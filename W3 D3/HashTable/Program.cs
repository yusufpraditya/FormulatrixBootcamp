using System.Collections;

public class Program 
{
	static void Main() 
	{
		// Not type safety collection, and not recommended.
		Hashtable ht = new Hashtable(){{3, "foo"}, {5, "bar"}};
		ht.Add("foo", 3);
		ht.Add("bar", 5);
		
		PrintHashTable(ht);
		
		ht.Remove(3);
		PrintHashTable(ht);
	}
	
	static void PrintHashTable(Hashtable ht) 
	{
		Console.WriteLine();
		foreach (DictionaryEntry de in ht) // Cannot use var
		{
			Console.WriteLine($"{de.Key} - {de.Value}");
		}
	}
}