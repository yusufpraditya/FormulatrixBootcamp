public class Program 
{
	static void Main() 
	{
		// HashSet is type safety
		// HashSet elements must be unique
		HashSet<int> hs1 = new();
		hs1.Add(1);
		hs1.Add(2);
		hs1.Add(2); // this will be discarded
		hs1.Add(3);
		hs1.Add(4);
		PrintHashSet(hs1, nameof(hs1));
		
		HashSet<int> hs2 = new HashSet<int>() {3, 4, 5, 6};
		PrintHashSet(hs2, nameof(hs2));
		
		HashSet<int> except = new HashSet<int>(hs1);
		except.ExceptWith(hs2);
		PrintHashSet(except, nameof(except));
		
		HashSet<int> union = new HashSet<int>(hs1);
		union.UnionWith(hs2);
		PrintHashSet(union, nameof(union));
		
		HashSet<int> intersect = new HashSet<int>(hs1);
		intersect.IntersectWith(hs2);
		PrintHashSet(intersect, nameof(intersect));
		
		Console.WriteLine($"except is subset of union: {except.IsSubsetOf(union)}");
		Console.WriteLine($"union is superset of except: {union.IsSupersetOf(except)}");
	}
	
	static void PrintHashSet(HashSet<int> hashSet, string varName) 
	{
		Console.Write(varName + ": ");
		foreach (var hs in hashSet) 
		{
			Console.Write($"{hs} ");
		}
		Console.WriteLine();
	}
}